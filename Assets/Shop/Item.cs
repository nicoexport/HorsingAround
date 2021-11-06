using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int id;
    public string name;
    public int cost;
    public float speedMultiplier;
    public string description;
    public Sprite icon;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    public Item(int id, string name, int cost, float speedMultiplier, 
    string description, Sprite icon, Dictionary<string, int> stats)
    {
        this.id = id;
        this.name = name;
        this.cost = cost;
        this.speedMultiplier = speedMultiplier;
        this.description = description;
        this.icon = Resources.Load<Sprite>("Shop/Art" + name);
        this.stats = stats;
    }

    public Item(Item item)    
    {
        this.id = item.id;
        this.name = item.name;
        this.cost = item.cost;
        this.speedMultiplier = item.speedMultiplier;
        this.description = item.description;
        this.icon = Resources.Load<Sprite>("Shop/Art" + name);
        this.stats = item.stats;
    }
}
