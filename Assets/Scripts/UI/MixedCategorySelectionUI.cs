using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MixedCategorySelectionUI : MonoBehaviour
{
    [Header("Category Toggles")]
    public Toggle gameOfThronesToggle;
    public Toggle harryPotterToggle;
    public Toggle starWarsToggle;
    public Toggle lordOfTheRingsToggle;

    [Header("UI")]
    public TMP_Text warningText;

    private void OnEnable()
    {
        if (warningText != null)
            warningText.text = "Select 2–3 categories to mix.";
    }

    public void OnMixClicked()
    {
        var gm = GameManager.Instance;
        var selected = new List<CategoryType>();

        if (gameOfThronesToggle != null && gameOfThronesToggle.isOn)
            selected.Add(CategoryType.GameOfThrones);

        if (harryPotterToggle != null && harryPotterToggle.isOn)
            selected.Add(CategoryType.HarryPotter);

        if (starWarsToggle != null && starWarsToggle.isOn)
             selected.Add(CategoryType.StarWars);

        if (lordOfTheRingsToggle != null && lordOfTheRingsToggle.isOn)
              selected.Add(CategoryType.LordOfTheRings);

        if (selected.Count < 2 || selected.Count > 3)
        {
            if (warningText != null)
                warningText.text = "Please select at least 2 and at most 3 categories.";
            return;
        }

        gm.SetMixedCategories(selected);
        

        UIManager.Instance.ShowDifficulty();
    }

    public void OnBackToCategories()
    {
        UIManager.Instance.ShowCategories();
    }
}
