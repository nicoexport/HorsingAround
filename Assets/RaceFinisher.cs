using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceFinisher : MonoBehaviour
{  
    [SerializeField]
    PlayerData playerData;
    [SerializeField]
    Transform player;
    [SerializeField]
    float conversionRate = 0.5f;

    public void AddCurrency()
    {   
    	var gain = player.position.x * conversionRate; 
        playerData.currency += (int)gain;
    }
}
