using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class  AudioSchmaudio: MonoBehaviour
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
            AudioManager.Instance.SourceBGM.clip = AudioManager.Instance.MarvinBGM;
            AudioManager.Instance.SourceBGM.Play();
        }
    }
}