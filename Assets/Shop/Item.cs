using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int id;
    public string name;

    public int cost;
    public string description;
    public Sprite icon;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    public Item(int id, string name, int cost,
    string description, Dictionary<string, int> stats)
    {
        this.id = id;
        this.cost = cost;
        this.name = name;
        this.description = description;
        this.icon = Resources.Load<Sprite>("Shop/" + name);
        this.stats = stats;
    }

    public Item(Item item)
    {
        this.id = item.id;
        this.cost = item.cost;
        this.name = item.name;
        this.description = item.description;
        this.icon = Resources.Load<Sprite>("Shop/" + name);
        this.stats = item.stats;
    }
}
