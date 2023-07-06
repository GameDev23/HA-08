using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertTrigger : MonoBehaviour
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
            DayNight.Instance.isDesert = true;
            if (DayNight.Instance.isNight)
                RenderSettings.skybox = DayNight.Instance.desertNight;
            else
            {
                RenderSettings.skybox = DayNight.Instance.desertDay;
            }
        }
    }
}
