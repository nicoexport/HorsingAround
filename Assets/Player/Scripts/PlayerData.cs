using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlayerData")]
public class PlayerData : ScriptableObject
{

    public List<ItemSO> allItems;
    public List<ItemSO> items;
    public int currency;

    public void AddItem(int id)
    {
        if(items.Contains(allItems[id])) return;
        if(currency - allItems[id].cost < 0) 
        {
            Debug.Log("Not enough cash");
            return;
        }
        items.Add(allItems[id]); 
        currency -= allItems[id].cost;  
    }

    public void RemoveItem(int id)
    {
        items.RemoveAt(id);
    }
}
