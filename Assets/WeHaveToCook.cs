using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeHaveToCook : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.Instance.SourceSFX.PlayOneShot(AudioManager.Instance.WeHaveToCook, 1f);
        }
    }
}
