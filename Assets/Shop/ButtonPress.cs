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

    public Tooltip tooltip;
    private bool mouseOver = false;

    void Update()
    {
        if (mouseOver)
        {
            Tooltip.ShowTooltip_Static(item.cost.ToString());
        }
        else
        {
            Tooltip.HideTooltip_Static();
        }
    }
    void Start()
    {
        button.onClick.AddListener(TaskOnClick);
    }
    public void TaskOnClick()
    {
        if (!playerData.items.Contains(item))
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
    }

}
