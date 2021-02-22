using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class destroyMusic1 : MonoBehaviour
{
    [SerializeField] private string theSong;
    [SerializeField] private string playSong;
    public AudioClip[] audioClips;

    void Start()
    {
        //Destroy(GameObject.Find(theSong));
        GameObject.Find(theSong).GetComponent<AudioSource>().Stop();
        GameObject.Find(theSong).GetComponent<AudioSource>().clip = audioClips[0];
        GameObject.Find(theSong).GetComponent<AudioSource>().loop = true;
        GameObject.Find(theSong).GetComponent<AudioSource>().Play();
    }
}
