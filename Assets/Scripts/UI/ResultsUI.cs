using TMPro;
using UnityEngine;

public class ResultsUI : MonoBehaviour
{
    public TMP_Text resultText;

    [Header("Result SFX")]
    public AudioClip perfectSfx; 
    public AudioClip goodSfx;  
    public AudioClip badSfx;

    private void OnEnable()
    {
        var gm = GameManager.Instance;

        int correct = gm.correctCount;
        int total = gm.currentRunQuestions.Count;

        int goldEarned = 0;
        int xpGained = 0;

        if (gm.CurrentMode == GameMode.Standard)
        {
            goldEarned = correct * gm.goldPerCorrect;
            gm.totalGold += goldEarned;

            gm.TryUpgradeRankAfterStandardRun();
            var rank = gm.GetCategoryRank(gm.selectedCategory);

            switch (gm.selectedDifficulty)
            {
                case QuestionDifficulty.Easy:
                    xpGained = correct * 2;  
                    break;
                case QuestionDifficulty.Medium:
                    xpGained = correct * 4;
                    break;
                case QuestionDifficulty.Hard:
                    xpGained = correct * 7;
                    break;
            }

            if (PlayerStats.Instance != null)
            {
                PlayerStats.Instance.AddXP(xpGained);
            }

            int currentLevel = PlayerStats.Instance != null ? PlayerStats.Instance.Level : 1;

            resultText.text =
                $"Category: {gm.selectedCategory}\n" +
                $"Difficulty: {gm.selectedDifficulty}\n" +
                $"Correct: {correct}/{total}\n" +
                $"Rank: {rank}\n" +
                $"Gold Earned: {goldEarned}\n" +
                $"Total Gold: {gm.totalGold}\n" +
                $"XP Earned: {xpGained}\n" +
                $"Level: {currentLevel}";
        }
        else
        {
            gm.UpdateBestEternalStreak();

            int best = gm.GetBestEternalStreak(gm.selectedCategory);
            var rank = gm.GetCategoryRank(gm.selectedCategory);

            xpGained = correct * 3; 

            if (PlayerStats.Instance != null)
            {
                PlayerStats.Instance.AddXP(xpGained);
            }

            int currentLevel = PlayerStats.Instance != null ? PlayerStats.Instance.Level : 1;

            resultText.text =
                $"ETERNAL MODE\n" +
                $"Category: {gm.selectedCategory}\n\n" +
                $"Streak: {correct}\n" +
                $"Best Streak: {best}\n" +
                $"Rank: {rank}\n" +
                $"XP Earned: {xpGained}\n" +
                $"Level: {currentLevel}";
        }

        if (GoldDisplay.Instance != null)
        {
            GoldDisplay.Instance.UpdateGold();
        }

        PlayResultSfx(correct, total);
    }



    private void PlayResultSfx(int correct, int total)
    {
        if (SfxManager.Instance == null)
            return;

        var gm = GameManager.Instance;

        if (gm.CurrentMode == GameMode.Eternal)
        {
            if (correct >= 20)
                SfxManager.Instance.PlaySfx(perfectSfx);
            else if (correct >= 10)
                SfxManager.Instance.PlaySfx(goodSfx);
            else
                SfxManager.Instance.PlaySfx(badSfx);

            return;
        }

        float accuracy = (float)correct / total;

        if (accuracy >= 1f)
            SfxManager.Instance.PlaySfx(perfectSfx);
        else if (accuracy >= 0.5f)
            SfxManager.Instance.PlaySfx(goodSfx);
        else
            SfxManager.Instance.PlaySfx(badSfx);
    }


    public void OnBackToMenu()
    {
        UIManager.Instance.ShowMainMenu();
    }
}

