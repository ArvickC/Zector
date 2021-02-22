using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buyLevelsManager : MonoBehaviour
{

    public string item;
    public string nextLevel;

    void Update()
    {
        if (backgroundAudio.itemsBoughtList.Contains(item))
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
