using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelButtonEnabledSummer : MonoBehaviour
{
    public int buttonLevel;
    public Button button;

    void Start()
    {
        if (backgroundAudio.summerLevelNumber >= buttonLevel)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }
}
