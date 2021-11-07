using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaBar : MonoBehaviour
{
    public Player player;
    public RectTransform rectTransform;

    private void OnEnable()
    {
        if(!rectTransform) rectTransform = GetComponent<RectTransform>();
        rectTransform.localScale = new Vector3(1,1,1);
    }

    private void Update()
    {   
        var xValue = new float();
         if (player.stamina > 0) xValue = (player.stamina / player.maxStamina);
        //float xValaue = Mathf.InverseLerp(0, 1, player.stamina); 
        rectTransform.localScale = new Vector3(xValue, 1f, 1f);
        Debug.Log(xValue);
    }
}
