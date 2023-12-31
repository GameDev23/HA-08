using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    public static AudioManager Instance;

    public AudioSource SourceBGM;
    public AudioSource SourceSFX;
    public AudioClip DavidCity;
    public AudioClip DavidDesert;
    public AudioClip DavidCityArea;
    public AudioClip WeHaveToCook;
    public AudioClip NewSamwelville;
    public AudioClip Freedom;
    public AudioClip SamwelBGM;
    public AudioClip MarvinBGM;

    
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
