using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelButtonEnabledNight : MonoBehaviour
{
    public int buttonLevel;
    public Button button;

    void Start()
    {
        if (backgroundAudio.nightLevelNumber >= buttonLevel)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }
}
