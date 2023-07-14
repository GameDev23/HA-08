using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerMarvin : MonoBehaviour
{
    
    public static AudioManagerMarvin Instance;

    public AudioSource SourceBGM;
    public AudioSource SourceSFX;
    public AudioClip Test;
    
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