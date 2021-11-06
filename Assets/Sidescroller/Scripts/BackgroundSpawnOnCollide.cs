using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawnOnCollide : MonoBehaviour
{
    public GameObject[] BGsAvailable;
    public GameObject backgroundCurrent;
    public GameObject backgroundNext;
    public GameObject backgroundOld;
    public float width;
    Collision nextBG;
    public float t;
    //int index;

    // Start is called before the first frame update
    void Start()
    {        
        backgroundCurrent = Instantiate(BGsAvailable[Random.Range(0, BGsAvailable.Length)], new Vector2(0, 0), transform.rotation);
        backgroundNext = Instantiate(BGsAvailable[Random.Range(0, BGsAvailable.Length)], new Vector2(32, 0), transform.rotation);
        backgroundOld = Instantiate(BGsAvailable[Random.Range(0, BGsAvailable.Length)], new Vector2(-32, 0), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
 
        if (nextBG.gameObject.name == "DummyPlayer")
        {
            Destroy(backgroundOld, t = 0.0f);
        
        }

    }
}
