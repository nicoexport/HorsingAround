using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonPress : MonoBehaviour
{
    public Button button;
    public ItemSO item;
    public PlayerData playerData;

    public UnityEvent sexEffex;


    void Start()
    {
        button.onClick.AddListener(TaskOnClick);
    }
    public void TaskOnClick()
    {
        //add current Feature to Player
        playerData.AddItem(item.id);
        sexEffex.Invoke();
        Object.Destroy(button.gameObject);



    }
}
