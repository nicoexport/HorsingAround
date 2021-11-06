using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPress : MonoBehaviour
{
    public Button button;

    void Start()
    {
        button.onClick.AddListener(TaskOnClick);
    }
    public void TaskOnClick()
    {
        //add current Feature to Player
        button.GetComponent<Image>().color = Color.red;
    }
}
