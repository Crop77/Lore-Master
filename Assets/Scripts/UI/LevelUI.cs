using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelUI : MonoBehaviour
{
    public static LevelUI Instance { get; private set; }

    public TMP_Text levelText;
    public TMP_Text xpText;
    public Slider xpSlider;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        var ps = PlayerStats.Instance;

        if (ps == null) return;

        levelText.text = $"Level {ps.Level}";
        xpText.text = $"{ps.CurrentXP} / {ps.XPToNextLevel} XP";

        xpSlider.maxValue = ps.XPToNextLevel;
        xpSlider.value = ps.CurrentXP;
    }
}
