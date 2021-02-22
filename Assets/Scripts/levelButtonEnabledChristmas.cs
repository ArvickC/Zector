using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelButtonEnabledChristmas : MonoBehaviour
{
    public int buttonLevel;
    public Button button;

    void Start()
    {
        if (backgroundAudio.christmasLevelNumber >= buttonLevel)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }
}
