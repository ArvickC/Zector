using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelTracker : MonoBehaviour
{

    public int level;

    void Start()
    {
        if(level >= backgroundAudio.levelNumber)
        {
            backgroundAudio.levelNumber = level;
        }
    }

    void Update()
    {
        
    }
}
