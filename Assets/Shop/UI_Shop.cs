using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UI_Shop : MonoBehaviour
{
    private Transform container;
    private Transform shopItemTemplate;
    private ItemDatabase database;

    private void Awake()
    {
        container = transform.Find("container");
        shopItemTemplate = container.Find("shopItemTemplate");
        shopItemTemplate.gameObject.SetActive(false);
    }

    private void Start()
    {
        database = new ItemDatabase();
        foreach (Item item in database.items)
        {
            CreateItemButton(item, item.id);
        }
    }

    private void CreateItemButton(Item item, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 40f;
        shopItemRectTransform.anchoredPosition = new Vector2(-130, -shopItemHeight * positionIndex);

        shopItemTransform.Find("costText").GetComponent<TextMeshProUGUI>().SetText(item.cost.ToString());
        shopItemTransform.Find("icon").GetComponent<Image>().sprite = item.icon;
        shopItemTransform.gameObject.SetActive(true);
    }
}
