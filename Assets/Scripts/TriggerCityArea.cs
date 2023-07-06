using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerCityArea : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.Instance.SourceBGM.clip = AudioManager.Instance.DavidCityArea;
            AudioManager.Instance.SourceBGM.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.Instance.SourceBGM.clip = AudioManager.Instance.DavidCity;
            AudioManager.Instance.SourceBGM.Play();
        }
    }
}
