using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DavidLevel : MonoBehaviour
{
    private bool prevIsDesert = false;
    // Start is called before the first frame update
    void Start()
    {
        prevIsDesert = DayNight.Instance.isDesert;
        if (DayNight.Instance.isDesert)
        {
            AudioManager.Instance.SourceBGM.clip = AudioManager.Instance.DavidDesert;
        }
        else
        {
            AudioManager.Instance.SourceBGM.clip = AudioManager.Instance.DavidCity;
        }
        
        AudioManager.Instance.SourceBGM.loop = true;
        AudioManager.Instance.SourceBGM.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (prevIsDesert != DayNight.Instance.isDesert)
        {
            prevIsDesert = DayNight.Instance.isDesert;
            if (DayNight.Instance.isDesert)
            {
                AudioManager.Instance.SourceBGM.clip = AudioManager.Instance.DavidDesert;
            }
            else
            {
                AudioManager.Instance.SourceBGM.clip = AudioManager.Instance.DavidCity;
            }
            
            AudioManager.Instance.SourceBGM.Play();
        }
    }
    
    
}
