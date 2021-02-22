using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelTrackerSummer : MonoBehaviour
{
    public int level;
    void Start()
    {
        if (level >= backgroundAudio.summerLevelNumber)
        {
            backgroundAudio.summerLevelNumber = level;
        }
    }
}
