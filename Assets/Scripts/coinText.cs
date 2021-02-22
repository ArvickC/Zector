using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinText : MonoBehaviour
{
    void Update()
    { 
        GameObject.Find("CoinNumber").GetComponent<Text>().text = backgroundAudio.coinsNumber.ToString();
    }
}
