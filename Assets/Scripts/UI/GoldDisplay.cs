using TMPro;
using UnityEngine;

public class GoldDisplay : MonoBehaviour
{
    public static GoldDisplay Instance { get; private set; }

    public TMP_Text goldText;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void Start()
    {
        UpdateGold();
    }

    public void UpdateGold()
    {
        if (GameManager.Instance == null || goldText == null) return;

        goldText.text = $"Gold: {GameManager.Instance.totalGold}";
    }
}
