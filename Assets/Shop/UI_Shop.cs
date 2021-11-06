using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;


public class UI_Shop : MonoBehaviour
{
    [SerializeField]
    private PlayerData playerData;
    private Transform container;
    private Transform shopItemTemplate;

    private void Awake()
    {
        container = transform.Find("container");
        shopItemTemplate = container.Find("shopItemTemplate");
        shopItemTemplate.gameObject.SetActive(false);
    }

    private void Start()
    {

        foreach (ItemSO item in playerData.allItems)
        {
            CreateItemButton(item, item.id);
        }
    }

    private void CreateItemButton(ItemSO item, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 40f;
        shopItemRectTransform.anchoredPosition = new Vector2(-130, -shopItemHeight * positionIndex);

        shopItemTransform.Find("costText").GetComponent<TextMeshProUGUI>().SetText(item.cost.ToString());
        shopItemTransform.Find("icon").GetComponent<Image>().sprite = item.icon;
        shopItemTransform.gameObject.SetActive(true);  
        shopItemTransform.GetComponent<Button>().onClick.AddListener(() => Unlock(positionIndex));
    }
    
    private void Unlock(int id)
    {
        playerData.AddItem(id);
    }
}
