using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Currency : MonoBehaviour
{
    private int currency;
    [SerializeField]
    private PlayerData playerData;
    // Start is called before the first frame update

    void Awake()
    {
        currency = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currency = playerData.currency;
        transform.Find("text").GetComponent<TextMeshProUGUI>().text = currency.ToString();
    }
}
