using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawnOnCollide : MonoBehaviour
{
    //varible to store all available backgrounds
    public GameObject[] BGsAvailable;
    //3 variables to store the background that are current in use
    public GameObject backgroundCurrent;
    public GameObject backgroundNext;
    public GameObject backgroundOld;

    //safe position of next bg for instantiation
    public float savePosBGNext;
    //width off the backgrounds
    public float width = 32;


    // Start is called before the first frame update
    void Start()
    {
        //Initial Instantiation of Level, generating the three starting backgrounds
        backgroundCurrent = Instantiate(BGsAvailable[Random.Range(0, BGsAvailable.Length)], new Vector2(0, 0), transform.rotation);
        backgroundNext = Instantiate(BGsAvailable[Random.Range(0, BGsAvailable.Length)], new Vector2(width, 0), transform.rotation);
        backgroundOld = Instantiate(BGsAvailable[Random.Range(0, BGsAvailable.Length)], new Vector2(-width, 0), transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "BackgroundTest")
        {
            //destroying the background on the very left of the level
            DestroyGameObject();
            //exchanging the referenced backgrounds of the variables 
            backgroundOld = backgroundCurrent;
            backgroundCurrent = backgroundNext;
            //saving the current position of the bg in the very right
            savePosBGNext = backgroundNext.transform.position.x;
            //instantiation the next background on the very right
            backgroundNext = Instantiate(BGsAvailable[Random.Range(0, BGsAvailable.Length)], new Vector2 (savePosBGNext + width, 0), transform.rotation);
            
            
            //Debug.Log("collided");

        }

    }

    void DestroyGameObject()
    {
        Destroy(backgroundOld);
    }


}
