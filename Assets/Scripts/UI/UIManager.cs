using UnityEngine;
using UnityEngine.Audio;

public class UIManager : MonoBehaviour
{
    public QuizController quizController;

    public static UIManager Instance { get; private set; }

    public GameObject xpPanel;

    [Header("Panels")]
    public GameObject mainMenuPanel;
    public GameObject categoriesPanel;
    public GameObject quizPanel;
    public GameObject resultsPanel;
    public GameObject difficultyPanel;
    public GameObject settingsPanel;
    public GameObject mixedCategoryPanel;

    public GameObject settingsButton;

    private enum ScreenState
    {
        MainMenu,
        Categories,
        Difficulty,
        Quiz,
        Results,
        Settings,
        MixedCategory
    }

    private ScreenState currentScreen;
    private ScreenState screenBeforeSettings;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        ShowMainMenu();
    }

    private void StopQuizTimerIfRunning()
    {
        QuizController qc = quizPanel.GetComponent<QuizController>();
        if (qc != null)
            qc.StopTimer();
    }

    public void ShowMainMenu()
    {
        currentScreen = ScreenState.MainMenu;

        mainMenuPanel.SetActive(true);
        categoriesPanel.SetActive(false);
        quizPanel.SetActive(false);
        resultsPanel.SetActive(false);
        difficultyPanel.SetActive(false);
        settingsPanel.SetActive(false);
        if (mixedCategoryPanel != null)
            mixedCategoryPanel.SetActive(false);

        if (xpPanel != null)
            xpPanel.SetActive(true);

        if (settingsButton != null)
            settingsButton.SetActive(true);

        if (GoldDisplay.Instance != null)
            GoldDisplay.Instance.UpdateGold();

        MusicManager.Instance.PlayMenuMusic();
    }

    public void ShowCategories()
    {
        currentScreen = ScreenState.Categories;

        mainMenuPanel.SetActive(false);
        categoriesPanel.SetActive(true);
        quizPanel.SetActive(false);
        resultsPanel.SetActive(false);
        difficultyPanel.SetActive(false);
        settingsPanel.SetActive(false);
        if (mixedCategoryPanel != null)
            mixedCategoryPanel.SetActive(false);

        if (xpPanel != null)
            xpPanel.SetActive(true);
        if (settingsButton != null)
            settingsButton.SetActive(true);
    }

    public void ShowDifficulty()
    {
        currentScreen = ScreenState.Difficulty;

        mainMenuPanel.SetActive(false);
        categoriesPanel.SetActive(false);
        difficultyPanel.SetActive(true);
        quizPanel.SetActive(false);
        resultsPanel.SetActive(false);
        settingsPanel.SetActive(false);
        if (mixedCategoryPanel != null)
            mixedCategoryPanel.SetActive(false);

        if (xpPanel != null)
            xpPanel.SetActive(false);
        if (settingsButton != null)
            settingsButton.SetActive(true);
    }

    public void ShowQuiz()
    {
        currentScreen = ScreenState.Quiz;

        mainMenuPanel.SetActive(false);
        categoriesPanel.SetActive(false);
        quizPanel.SetActive(true);
        resultsPanel.SetActive(false);
        difficultyPanel.SetActive(false);
        settingsPanel.SetActive(false);
        if (mixedCategoryPanel != null)
            mixedCategoryPanel.SetActive(false);

        if (xpPanel != null)
            xpPanel.SetActive(false);
        if (settingsButton != null)
            settingsButton.SetActive(false);

        MusicManager.Instance.PlayQuizMusic();
    }

    public void ShowResults()
    {
        currentScreen = ScreenState.Results;

        mainMenuPanel.SetActive(false);
        categoriesPanel.SetActive(false);
        quizPanel.SetActive(false);
        resultsPanel.SetActive(true);
        difficultyPanel.SetActive(false);
        settingsPanel.SetActive(false);
        if (mixedCategoryPanel != null)
            mixedCategoryPanel.SetActive(false);

        if (settingsButton != null)
            settingsButton.SetActive(true);
        if (xpPanel != null)
            xpPanel.SetActive(true);

        QuizController qc = quizPanel.GetComponent<QuizController>();
        if (qc != null)
            qc.StopTimer();
    }

    public void ShowSettings()
    {
        screenBeforeSettings = currentScreen;
        currentScreen = ScreenState.Settings;

        StopQuizTimerIfRunning();

        mainMenuPanel.SetActive(false);
        categoriesPanel.SetActive(false);
        quizPanel.SetActive(false);
        resultsPanel.SetActive(false);
        difficultyPanel.SetActive(false);
        if (mixedCategoryPanel != null)
            mixedCategoryPanel.SetActive(false);
        if (xpPanel != null)
            xpPanel.SetActive(false);

        settingsPanel.SetActive(true);

        if (settingsButton != null)
            settingsButton.SetActive(false);
    }

    public void ShowMixedCategorySelection()
    {
        currentScreen = ScreenState.MixedCategory;

        mainMenuPanel.SetActive(false);
        categoriesPanel.SetActive(false);
        quizPanel.SetActive(false);
        resultsPanel.SetActive(false);
        difficultyPanel.SetActive(false);
        settingsPanel.SetActive(false);

        if (mixedCategoryPanel != null)
            mixedCategoryPanel.SetActive(true);

        if (xpPanel != null)
            xpPanel.SetActive(true);
        if (settingsButton != null)
            settingsButton.SetActive(true);
    }

    public void HideSettings()
    {
        switch (screenBeforeSettings)
        {
            case ScreenState.MainMenu:
                ShowMainMenu();
                break;

            case ScreenState.Categories:
                ShowCategories();
                break;

            case ScreenState.Difficulty:
                ShowDifficulty();
                break;

            case ScreenState.Quiz:
                ShowQuiz();
                break;

            case ScreenState.Results:
                ShowResults();
                break;

            case ScreenState.MixedCategory:
                ShowMixedCategorySelection();
                break;

            default:
                ShowMainMenu();
                break;
        }
    }
}


