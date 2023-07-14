using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class  AreaMusic: MonoBehaviour
{
    [SerializeField] AudioClip musicClip;// The audio clip to play when entering this area
    private bool isPlayerInside;
    private AudioManager audioManager;


    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.Instance.SourceBGM.clip = musicClip;
            AudioManager.Instance.SourceBGM.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.Instance.SourceBGM.clip = AudioManager.Instance.SamwelBGM;
            AudioManager.Instance.SourceBGM.Play();
        }
    }
}
