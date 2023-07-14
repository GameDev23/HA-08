using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  NewSamwelVilleMusic: MonoBehaviour
{
    public AudioClip musicClip;  // The audio clip to play when entering this area
    private AudioSource audioSource;
    private bool isPlayerInside;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.clip = musicClip;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = true;
            PlayMusic();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = false;
            StopMusic();
        }
    }

    void PlayMusic()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    void StopMusic()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
