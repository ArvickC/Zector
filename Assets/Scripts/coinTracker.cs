using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinTracker : MonoBehaviour
{

    public AudioSource collectSound;

    public int level;

    void Start()
    {
        if (backgroundAudio.coinCollectedLevelList.Contains(level))
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            collectSound.Play();
            Destroy(this.gameObject);
            backgroundAudio.coinsNumber+=2;
            backgroundAudio.coinCollectedLevelList.Add(level);
        }
    }
}
