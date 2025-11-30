using TMPro;
using UnityEngine;

public class LevelUpPopupUI : MonoBehaviour
{
    public static LevelUpPopupUI Instance { get; private set; }

    public TMP_Text titleText;
    public TMP_Text levelText;
    public AudioClip levelUpSfx;

    public void Show(int newLevel)
    {
        Debug.Log($"[LevelUpPopupUI] Show({newLevel}) called.");

        if (titleText != null)
            titleText.text = "LEVEL UP!";

        if (levelText != null)
            levelText.text = $"You reached Level {newLevel}";

        if (levelUpSfx != null && SfxManager.Instance != null)
        {
            SfxManager.Instance.PlaySfx(levelUpSfx);
        }

        gameObject.SetActive(true);
        Debug.Log("[LevelUpPopupUI] Panel set active.");
    }

    public void OnClickOk()
    {
        gameObject.SetActive(false);
    }
}

