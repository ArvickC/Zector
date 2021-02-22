using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startAudio : MonoBehaviour
{

    public AudioSource theSong;
    [SerializeField] private string foo;

    void Start()
    {
        //Destroy(GameObject.Find("Audio"));

        //GetComponent<AudioSource>().Stop();
        //GameObject.Find("Audio").GetComponent<AudioSource>().Stop();
        //theSong.Play();
    }
}
