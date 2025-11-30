using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats Instance { get; private set; }

    public int Level { get; private set; } = 1;
    public int CurrentXP { get; private set; } = 0;

    [SerializeField] private LevelUpPopupUI levelUpPopup;
    public int XPToNextLevel => CalculateRequiredXP(Level);

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


    public void AddXP(int amount)
    {
        if (amount <= 0) return;

        CurrentXP += amount;
        Debug.Log($"[PlayerStats] Added {amount} XP. New XP = {CurrentXP}");

        bool leveledUp = false;

        while (CurrentXP >= XPToNextLevel)
        {
            CurrentXP -= XPToNextLevel;
            Level++;
            leveledUp = true;
            Debug.Log($"[PlayerStats] LEVEL UP! New Level = {Level}");
        }

        if (LevelUI.Instance != null)
        {
            LevelUI.Instance.UpdateUI();
        }
        else
        {
            Debug.LogWarning("[PlayerStats] LevelUI.Instance is null, cannot update XP UI.");
        }

        if (leveledUp)
        {
            Debug.Log("[PlayerStats] Trying to show level-up popup…");

            LevelUpPopupUI popup = levelUpPopup != null ? levelUpPopup : LevelUpPopupUI.Instance;

            if (popup != null)
            {
                Debug.Log("[PlayerStats] Popup reference is not null, calling Show().");
                popup.Show(Level);
            }
            else
            {
                Debug.LogWarning("[PlayerStats] No LevelUpPopupUI found (both reference and Instance are null).");
            }
        }

    }




    private int CalculateRequiredXP(int level)
    {
        return Mathf.RoundToInt(20 * Mathf.Pow(level, 1.4f));
    }
}
