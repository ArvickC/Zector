using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuStart : MonoBehaviour
{

    public string firstScene;

    public void changescene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

    public void FirstSceneChange(string sceneName)
    {
        if (backgroundAudio.levelNumber == 1)
        {
            SceneManager.LoadScene(firstScene);
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void QuitGame()
    {
        backgroundAudio.StopTimer();
        Application.Quit();
        Debug.Log("QUIT!");
    }

}
