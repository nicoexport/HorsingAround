using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ButtonPress : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Button button;
    public ItemSO item;
    public PlayerData playerData;

    public UnityEvent sexEffex;
    private bool mouseOver = false;

    void Update()
    {
        if (mouseOver)
        {
            print(item.name);
            Tooltip.ShowTooltip_Static(item.cost.ToString());
        }
        /*if (!mouseOver)
        {
            Tooltip.HideTooltip_Static();
        }*/
    }
    void Start()
    {
        button.onClick.AddListener(TaskOnClick);
        if (playerData.items.Contains(item))
        {
            button.gameObject.SetActive(false);
        }
    }
    public void TaskOnClick()
    {
        if (!playerData.items.Contains(item) && playerData.currency >= item.cost)
        {
            //add current Feature to Player
            playerData.AddItem(item.id);
            sexEffex.Invoke();
            Object.Destroy(button.gameObject);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouseOver = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouseOver = false;
        Tooltip.HideTooltip_Static();
    }

}
