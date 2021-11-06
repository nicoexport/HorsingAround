using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlayerData")]
public class PlayerData : ScriptableObject
{

    public List<ItemSO> allItems;
    public List<ItemSO> items;

    public void AddItem(int id)
    {
        if(items.Contains(allItems[id])) return;
        items.Add(allItems[id]); 
    }

    public void RemoveItem(int id)
    {
        items.RemoveAt(id);
    }
}
