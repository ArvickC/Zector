using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boughtItem : MonoBehaviour
{

    public string item;

   void Start()
    {
        if (backgroundAudio.itemsBoughtList.Contains(item))
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }
}
