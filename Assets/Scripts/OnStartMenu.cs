using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartMenu : MonoBehaviour
{
    public AudioClip[] audioClips;
    [SerializeField] private string theSong;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find(theSong).GetComponent<AudioSource>().Stop();
        GameObject.Find(theSong).GetComponent<AudioSource>().clip = audioClips[0];
        GameObject.Find(theSong).GetComponent<AudioSource>().loop = true;
        GameObject.Find(theSong).GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
