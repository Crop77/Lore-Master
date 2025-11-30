using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public enum CategoryRank
{
    None = 0,
    Bronze = 1,
    Silver = 2,
    Gold = 3,
    Diamond = 4
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public GameMode CurrentMode { get; private set; } = GameMode.Standard;


    public int totalGold;
    public int goldPerCorrect = 10;
    public int maxQuestionsPerRun = 10;
    public QuestionDifficulty selectedDifficulty = QuestionDifficulty.Easy;

    public int mediumCost = 100;
    public int hardCost = 300;
    public int eternalCost = 500;

    private Dictionary<CategoryType, HashSet<QuestionDifficulty>> unlockedDifficulties;
    private HashSet<CategoryType> unlockedEternal;

    public CategoryType selectedCategory;

    private Dictionary<CategoryType, List<QuestionData>> questionBank;
    public List<QuestionData> currentRunQuestions = new List<QuestionData>();

    public bool mixedCategoryUnlocked = true;   // TODO: set false and hook to monetization later
    public bool isMixedRun = false;
    public List<CategoryType> mixedSelectedCategories = new List<CategoryType>();

    public int mixedQuestionsPerRun = 20;


    public int currentQuestionIndex;
    public int correctCount;

    private Dictionary<CategoryType, CategoryRank> categoryRanks = new Dictionary<CategoryType, CategoryRank>();
    public int eternalDiamondThreshold = 20;
    private Dictionary<CategoryType, int> eternalBestStreaks = new Dictionary<CategoryType, int>();



    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        questionBank = QuestionDatabase.BuildQuestionBank();

        unlockedDifficulties = new Dictionary<CategoryType, HashSet<QuestionDifficulty>>
        {
             { CategoryType.GameOfThrones, new HashSet<QuestionDifficulty> { QuestionDifficulty.Easy } },
             { CategoryType.HarryPotter,   new HashSet<QuestionDifficulty> { QuestionDifficulty.Easy } }
        };

        unlockedEternal = new HashSet<CategoryType>();

        foreach (CategoryType cat in System.Enum.GetValues(typeof(CategoryType)))
        {
            categoryRanks[cat] = CategoryRank.None;
            eternalBestStreaks[cat] = 0;
        }


    }

    public bool IsDifficultyUnlocked(CategoryType cat, QuestionDifficulty diff)
    {
        return unlockedDifficulties.TryGetValue(cat, out var set) && set.Contains(diff);
    }

    public void UnlockDifficulty(CategoryType cat, QuestionDifficulty diff)
    {
        if (!unlockedDifficulties.TryGetValue(cat, out var set))
        {
            set = new HashSet<QuestionDifficulty>();
            unlockedDifficulties[cat] = set;
        }

        set.Add(diff);
    }

    public bool IsEternalUnlocked(CategoryType cat)
    {
        return unlockedEternal.Contains(cat);
    }

    public void UnlockEternal(CategoryType cat)
    {
        unlockedEternal.Add(cat);
    }


    public void SelectCategory(CategoryType category)
    {
        selectedCategory = category;
        isMixedRun = false;
    }

    public void SetMixedCategories(List<CategoryType> categories)
    {
        isMixedRun = true;
        mixedSelectedCategories = new List<CategoryType>(categories);
    }


    private List<QuestionData> GetRandomQuestions(CategoryType cat, QuestionDifficulty diff)
    {
        if (!questionBank.TryGetValue(cat, out var allQuestions))
        {
            Debug.LogError("No questions for category " + cat);
            return new List<QuestionData>();
        }

        var pool = allQuestions
            .Where(q => q.difficulty == diff)
            .ToList();

        if (pool.Count == 0)
            pool = allQuestions.ToList();

        ShuffleList(pool);

        int count = Mathf.Min(maxQuestionsPerRun, pool.Count);

        var output = new List<QuestionData>();
        for (int i = 0; i < count; i++)
        {
            output.Add(CloneWithShuffledAnswers(pool[i]));
        }

        return output;
    }


    private void ShuffleList<T>(IList<T> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = UnityEngine.Random.Range(0, i + 1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }

    private QuestionData CloneWithShuffledAnswers(QuestionData source)
    {
        var copy = new QuestionData();
        copy.questionText = source.questionText;
        copy.difficulty = source.difficulty;

        string[] originalAnswers = (string[])source.answers.Clone();
        int originalCorrect = source.correctIndex;

        int n = originalAnswers.Length;
        int[] order = new int[n];

        for (int i = 0; i < n; i++)
            order[i] = i;

        ShuffleList(order);

        string[] newAnswers = new string[n];
        int newCorrect = 0;

        for (int i = 0; i < n; i++)
        {
            int oldIndex = order[i];
            newAnswers[i] = originalAnswers[oldIndex];

            if (oldIndex == originalCorrect)
                newCorrect = i;
        }

        copy.answers = newAnswers;
        copy.correctIndex = newCorrect;

        return copy;
    }

    private void ShuffleList(int[] array)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = UnityEngine.Random.Range(0, i + 1);
            (array[i], array[j]) = (array[j], array[i]);
        }
    }



    public void StartQuizRun()
    {
        if (isMixedRun)
        {
            currentRunQuestions = GetMixedQuestions();
        }
        else
        {
            currentRunQuestions = GetRandomQuestions(selectedCategory, selectedDifficulty);
        }

        currentQuestionIndex = 0;
        correctCount = 0;
    }


    public void StartEternalRun()
    {
        CurrentMode = GameMode.Eternal;

        currentRunQuestions = GetRandomQuestionsForEternal(selectedCategory);

        currentQuestionIndex = 0;
        correctCount = 0;
    }

    private List<QuestionData> GetRandomQuestionsForEternal(CategoryType cat)
    {
        if (!questionBank.TryGetValue(cat, out var allQuestions))
        {
            Debug.LogError("No questions for category " + cat);
            return new List<QuestionData>();
        }

        var pool = allQuestions.ToList();

        ShuffleList(pool);

        var output = new List<QuestionData>();
        foreach (var q in pool)
        {
            output.Add(CloneWithShuffledAnswers(q));
        }

        return output;
    }




    public QuestionData GetCurrentQuestion()
    {
        if (currentQuestionIndex < 0 || currentQuestionIndex >= currentRunQuestions.Count)
            return null;

        return currentRunQuestions[currentQuestionIndex];
    }

    public bool HasMoreQuestions()
    {
        return currentQuestionIndex + 1 < currentRunQuestions.Count;
    }

    public int GetBestEternalStreak(CategoryType cat)
    {
        if (eternalBestStreaks.TryGetValue(cat, out int best))
            return best;

        return 0;
    }


    public void UpdateBestEternalStreak()
    {
        if (CurrentMode != GameMode.Eternal)
            return;

        var cat = selectedCategory;
        int currentStreak = correctCount;

        int best = GetBestEternalStreak(cat);

        if (currentStreak > best)
        {
            best = currentStreak;
            eternalBestStreaks[cat] = best;
        }

        var currentRank = GetCategoryRank(cat);
        if (best >= eternalDiamondThreshold && currentRank < CategoryRank.Diamond)
        {
            SetCategoryRank(cat, CategoryRank.Diamond);
        }
    }



    public CategoryRank GetCategoryRank(CategoryType cat)
    {
        if (categoryRanks.TryGetValue(cat, out var rank))
            return rank;

        return CategoryRank.None;
    }

    private void SetCategoryRank(CategoryType cat, CategoryRank newRank)
    {
        categoryRanks[cat] = newRank;
    }

    public void TryUpgradeRankAfterStandardRun()
    {
        if (CurrentMode != GameMode.Standard)
            return;

        var cat = selectedCategory;
        var current = GetCategoryRank(cat);
        var newRank = current;

        switch (selectedDifficulty)
        {
            case QuestionDifficulty.Easy:
                if (current < CategoryRank.Bronze) newRank = CategoryRank.Bronze;
                break;

            case QuestionDifficulty.Medium:
                if (current < CategoryRank.Silver) newRank = CategoryRank.Silver;
                break;

            case QuestionDifficulty.Hard:
                if (current < CategoryRank.Gold) newRank = CategoryRank.Gold;
                break;
        }

        if (newRank != current)
            SetCategoryRank(cat, newRank);
    }

    private List<QuestionData> GetMixedQuestions()
    {
        var pool = new List<QuestionData>();

        foreach (var cat in mixedSelectedCategories)
        {
            if (!questionBank.TryGetValue(cat, out var allQuestionsForCat))
                continue;

            if (CurrentMode == GameMode.Eternal)
            {
                
                pool.AddRange(allQuestionsForCat);
            }
            else
            {
                
                pool.AddRange(allQuestionsForCat.Where(q => q.difficulty == selectedDifficulty));
            }
        }

        if (pool.Count == 0 && questionBank.TryGetValue(selectedCategory, out var fallbackList))
        {
            pool.AddRange(fallbackList.Where(q => q.difficulty == selectedDifficulty));
        }

        ShuffleList(pool);


        int count;
        if (CurrentMode == GameMode.Eternal)
        {
            count = pool.Count;
        }
        else
        {
            count = Mathf.Min(mixedQuestionsPerRun, pool.Count);
        }

        var output = new List<QuestionData>();
        for (int i = 0; i < count; i++)
        {
            output.Add(CloneWithShuffledAnswers(pool[i]));
        }

        return output;
    }



}







