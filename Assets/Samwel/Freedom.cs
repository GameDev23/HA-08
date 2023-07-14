using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freedom : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.Instance.SourceSFX.PlayOneShot(AudioManager.Instance.Freedom, 4f);
        }
    }
}
