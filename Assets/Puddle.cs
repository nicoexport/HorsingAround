using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puddle : MonoBehaviour
{   
    [SerializeField]
    private float drag = 1f;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag != "Player") return;
        col.GetComponent<Player>().rb.drag = drag;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag != "Player") return;
        var player = col.GetComponent<Player>();
        player.rb.drag = player.defaultDrag;
    }


}
