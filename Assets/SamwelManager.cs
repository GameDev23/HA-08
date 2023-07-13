using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamwelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        AudioManager.Instance.SourceBGM.clip = AudioManager.Instance.SamwelBGM;
        AudioManager.Instance.SourceBGM.volume = 1f;
        if(AudioManager.Instance.SourceBGM.clip != null)
            AudioManager.Instance.SourceBGM.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
