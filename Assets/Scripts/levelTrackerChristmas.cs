using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelTrackerChristmas : MonoBehaviour
{
    public int level;
    void Start()
    {
        if (level >= backgroundAudio.christmasLevelNumber)
        {
            backgroundAudio.christmasLevelNumber = level;
        }
    }
}
