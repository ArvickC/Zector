using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introWait : MonoBehaviour
{

    public float waitTime = 12f;
    public string nextScene;

    void Start()
    {
        StartCoroutine(waitForIntro());
    }

    IEnumerator waitForIntro()
    {
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(nextScene);
    }
}
