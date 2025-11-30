using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static GameManager;

public class CategoryButtonUI : MonoBehaviour
{
    public TMP_Text categoryNameText;
    private CategoryType category;
    public Image backgroundImage;

    [Header("Rank Colors")]
    public Color bronzeColor = new Color(0.8f, 0.5f, 0.2f);
    public Color silverColor = new Color(0.75f, 0.75f, 0.8f);
    public Color goldColor = new Color(0.95f, 0.8f, 0.2f);
    public Color diamondColor = new Color(0.4f, 0.9f, 1f);
    public Color defaultColor = Color.white;

    private bool isMixedButton = false;

    public void Setup(CategoryType category, string displayName)
    {
        isMixedButton = false;
        this.category = category;

        var gm = GameManager.Instance;
        string rankText = "";
        var rank = gm.GetCategoryRank(category);

        switch (rank)
        {
            case CategoryRank.Bronze: rankText = " [Bronze]"; break;
            case CategoryRank.Silver: rankText = " [Silver]"; break;
            case CategoryRank.Gold: rankText = " [Gold]"; break;
            case CategoryRank.Diamond: rankText = " [Diamond]"; break;
        }

        categoryNameText.text = displayName + rankText;

        if (backgroundImage != null)
        {
            switch (rank)
            {
                case CategoryRank.Bronze: backgroundImage.color = bronzeColor; break;
                case CategoryRank.Silver: backgroundImage.color = silverColor; break;
                case CategoryRank.Gold: backgroundImage.color = goldColor; break;
                case CategoryRank.Diamond: backgroundImage.color = diamondColor; break;
                default: backgroundImage.color = defaultColor; break;
            }
        }
    }

    public void SetupMixed(string displayName)
    {
        isMixedButton = true;
        categoryNameText.text = displayName;

        if (backgroundImage != null)
        {
            backgroundImage.color = new Color(0.5f, 0.2f, 0.8f);
        }
    }

    public void OnClick()
    {
        if (isMixedButton)
        {
            var gm = GameManager.Instance;

            if (!gm.mixedCategoryUnlocked)
            {
                Debug.Log("Mixed Category is locked. TODO: show monetization popup.");
                return;
            }

            UIManager.Instance.ShowMixedCategorySelection();
        }
        else
        {
            GameManager.Instance.SelectCategory(category);
            UIManager.Instance.ShowDifficulty();
        }
    }
}


