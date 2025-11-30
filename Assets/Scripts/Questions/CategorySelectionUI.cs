using System.Collections.Generic;
using UnityEngine;

public class CategorySelectionUI : MonoBehaviour
{
    [System.Serializable]
    public class CategoryInfo
    {
        public CategoryType type;
        public string displayName;
    }

    [Header("Scroll View Content")]
    public Transform contentParent;

    [Header("Prefabs")]
    public GameObject categoryButtonPrefab;

    [Header("Categories")]
    public List<CategoryInfo> categories = new List<CategoryInfo>();

    private void Start()
    {
        BuildCategoryButtons();
    }

    private void OnEnable()
    {
        BuildCategoryButtons();
    }

    private void BuildCategoryButtons()
    {
        foreach (Transform child in contentParent)
            Destroy(child.gameObject);

        foreach (var cat in categories)
        {
            GameObject btnObj = Instantiate(categoryButtonPrefab, contentParent);
            var btnUI = btnObj.GetComponent<CategoryButtonUI>();
            btnUI.Setup(cat.type, cat.displayName);
        }

        {
            GameObject mixedObj = Instantiate(categoryButtonPrefab, contentParent);
            var mixedUI = mixedObj.GetComponent<CategoryButtonUI>();
            mixedUI.SetupMixed("MIXED CATEGORY");
        }
    }
}

