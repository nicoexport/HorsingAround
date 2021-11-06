using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="ItemSO")]
public class ItemSO : ScriptableObject
{
    public int id;
    public string itemName;
    public int cost;
    public string description;
    public Sprite icon;
    public float moveSpeedMulti;
    public float jumpForceMulti;
    public float staminaGain;
}
