using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelTrackerNight : MonoBehaviour
{
    public int level;
    void Start()
    {
        if (level >= backgroundAudio.nightLevelNumber)
        {
            backgroundAudio.nightLevelNumber = level;
        }
    }
}
