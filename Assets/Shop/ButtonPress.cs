using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPress : MonoBehaviour
{
    public Button button;
    public ItemSO item;
    public PlayerData playerData;

    void Start()
    {
        button.onClick.AddListener(TaskOnClick);
    }
    public void TaskOnClick()
    {
        //add current Feature to Player
        playerData.AddItem(item.id);
    }
}
