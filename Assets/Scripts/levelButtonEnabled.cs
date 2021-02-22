using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelButtonEnabled : MonoBehaviour
{

    public int buttonLevel;
    public Button button;

    void Start()
    {
        if(backgroundAudio.levelNumber >= buttonLevel)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }

    void Update()
    {
        
    }
}
