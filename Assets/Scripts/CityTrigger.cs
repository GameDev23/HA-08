using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityTrigger : MonoBehaviour
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
            DayNight.Instance.isDesert = false;
            if (DayNight.Instance.isNight)
                RenderSettings.skybox = DayNight.Instance.skyNight;
            else
            {
                RenderSettings.skybox = DayNight.Instance.skyDay;
            }
        }
    }
}
