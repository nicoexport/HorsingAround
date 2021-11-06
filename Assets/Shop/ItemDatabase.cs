using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase
{
    public List<Item> items = new List<Item>();

    public ItemDatabase()
    {
        BuildDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string itemName)
    {
        return items.Find(item => item.name == itemName);
    }

    void BuildDatabase()
    {
        items = new List<Item>(){
            new Item(0, "Frog",20, "Its a test frog",
            new Dictionary<string, int>
            {
                {"Cost", 10},
                {"SpeedMultiplier", 2},
            }),

            new Item(1, "Heart",300, "Its a test frog",
            new Dictionary<string, int>
            {
                {"Cost", 20},
                {"SpeedMultiplier", 20},
            }),
        };
    }
}
