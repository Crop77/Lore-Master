using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DifficultySelectionUI : MonoBehaviour
{
    public TMP_Text easyLabel;
    public TMP_Text mediumLabel;
    public TMP_Text hardLabel;
    public TMP_Text eternalLabel;

    [Header("Button Backgrounds")]
    public Image easyButtonImage;
    public Image mediumButtonImage;
    public Image hardButtonImage;
    public Image eternalButtonImage;

    [Header("Rank Colors")]
    public Color bronzeColor = new Color(0.8f, 0.5f, 0.2f);
    public Color silverColor = new Color(0.75f, 0.75f, 0.8f);
    public Color goldColor = new Color(0.95f, 0.8f, 0.2f);
    public Color diamondColor = new Color(0.4f, 0.9f, 1f);
    public Color lockedTint = new Color(0.3f, 0.3f, 0.3f);


    private void OnEnable()
    {
        RefreshUI();
    }

    private void RefreshUI()
    {
        var gm = GameManager.Instance;
        var cat = gm.selectedCategory;

        easyLabel.text = "Easy (Unlocked)";

        if (gm.IsDifficultyUnlocked(cat, QuestionDifficulty.Medium))
        {
            mediumLabel.text = "Medium (Unlocked)";
        }
        else
        {
            mediumLabel.text = $"Medium - Pay {gm.mediumCost} Gold to Unlock";
        }

        if (gm.IsDifficultyUnlocked(cat, QuestionDifficulty.Hard))
        {
            hardLabel.text = "Hard (Unlocked)";
        }
        else
        {
            hardLabel.text = $"Hard - Pay {gm.hardCost} Gold to Unlock";
        }

        if (gm.IsEternalUnlocked(cat))
        {
            eternalLabel.text = "ETERNAL UNLEASHED";
        }
        else
        {
            eternalLabel.text =
                $"ETERNAL (YOU ARE NOT PREPARED)\n" +
                $"Unlock Cost: {gm.eternalCost} Gold";
        }

        if (easyButtonImage != null)
            easyButtonImage.color = bronzeColor;

        if (mediumButtonImage != null)
        {
            mediumButtonImage.color = gm.IsDifficultyUnlocked(cat, QuestionDifficulty.Medium)
                ? silverColor
                : lockedTint;
        }

        if (hardButtonImage != null)
        {
            hardButtonImage.color = gm.IsDifficultyUnlocked(cat, QuestionDifficulty.Hard)
                ? goldColor
                : lockedTint;
        }

        if (eternalButtonImage != null)
        {
            eternalButtonImage.color = gm.IsEternalUnlocked(cat)
                ? diamondColor
                : lockedTint;
        }
    }

    public void OnEasyClicked()
    {
        var gm = GameManager.Instance;
        gm.selectedDifficulty = QuestionDifficulty.Easy;
        gm.StartQuizRun();
        UIManager.Instance.ShowQuiz();
    }

    public void OnMediumClicked()
    {
        var gm = GameManager.Instance;
        var cat = gm.selectedCategory;

        if (gm.IsDifficultyUnlocked(cat, QuestionDifficulty.Medium))
        {
            gm.selectedDifficulty = QuestionDifficulty.Medium;
            gm.StartQuizRun();
            UIManager.Instance.ShowQuiz();
        }
        else
        {
            int cost = gm.mediumCost;

            if (gm.totalGold >= cost)
            {
                gm.totalGold -= cost;
                gm.UnlockDifficulty(cat, QuestionDifficulty.Medium);

                if (GoldDisplay.Instance != null)
                    GoldDisplay.Instance.UpdateGold();

                gm.selectedDifficulty = QuestionDifficulty.Medium;
                gm.StartQuizRun();
                UIManager.Instance.ShowQuiz();
            }
            else
            {
                Debug.Log("Not enough gold to unlock Medium difficulty.");
            }
        }
    }

    public void OnHardClicked()
    {
        var gm = GameManager.Instance;
        var cat = gm.selectedCategory;

        if (gm.IsDifficultyUnlocked(cat, QuestionDifficulty.Hard))
        {
            gm.selectedDifficulty = QuestionDifficulty.Hard;
            gm.StartQuizRun();
            UIManager.Instance.ShowQuiz();
        }
        else
        {
            int cost = gm.hardCost;

            if (gm.totalGold >= cost)
            {
                gm.totalGold -= cost;
                gm.UnlockDifficulty(cat, QuestionDifficulty.Hard);

                if (GoldDisplay.Instance != null)
                    GoldDisplay.Instance.UpdateGold();

                gm.selectedDifficulty = QuestionDifficulty.Hard;
                gm.StartQuizRun();
                UIManager.Instance.ShowQuiz();
            }
            else
            {
                Debug.Log("Not enough gold to unlock Hard difficulty.");
            }
        }
    }

    public void OnEternalClicked()
    {
        var gm = GameManager.Instance;
        var cat = gm.selectedCategory;

        if (gm.IsEternalUnlocked(cat))
        {
            gm.StartEternalRun();
            UIManager.Instance.ShowQuiz();
        }
        else
        {
            int cost = gm.eternalCost;

            if (gm.totalGold >= cost)
            {
                gm.totalGold -= cost;
                gm.UnlockEternal(cat);

                if (GoldDisplay.Instance != null)
                    GoldDisplay.Instance.UpdateGold();

                gm.StartEternalRun();
                UIManager.Instance.ShowQuiz();
            }
            else
            {
                Debug.Log("Not enough gold to unlock Eternal Mode.");
            }
        }
    }


}
