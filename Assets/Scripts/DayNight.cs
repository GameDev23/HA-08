using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    public static DayNight Instance;
    public Material skyDay;
    public Material skyNight;
    public Material desertDay;
    public Material desertNight;
    public Light light;

    public Color dayColor;
    public Color nightColor;

    public float dayIntensity;
    public float nightIntensity;

    public bool isDesert = false;

    public bool isNight = false;
    
    
    void Awake()
    {
        //create signleton
        if(Instance == null)
            Instance = this;
        else if(Instance != this)
            Destroy(gameObject);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
       // originColor = RenderSettings.skybox.color;
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("KeyQ"))
        {
            Debug.Log("Pressed Q");
            if (isDesert)
            {
                RenderSettings.skybox = desertDay;


            }
            else
            {
                RenderSettings.skybox = skyDay;

            }

            isNight = false;
            light.color = dayColor;
            light.intensity = dayIntensity;

        }

        if (Input.GetButtonDown("KeyE"))
        {
            Debug.Log("Pressed E");
            if (isDesert)
            {
                RenderSettings.skybox = desertNight;

            }
            else
            {
                RenderSettings.skybox = skyNight;
                
            }

            isNight = true;
            light.color = nightColor;
            light.intensity = nightIntensity;

        }
    }
    

}
