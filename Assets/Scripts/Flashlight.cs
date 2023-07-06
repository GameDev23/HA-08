using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] private GameObject flashlight;

    [SerializeField] private AudioClip lightSFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("KeyF"))
            ToggleFlashlight();
    }

    void ToggleFlashlight()
    {
        Debug.Log("Toggle Flashlight");
        AudioManager.Instance.SourceSFX.PlayOneShot(lightSFX);
        flashlight.SetActive(!flashlight.activeSelf);
    }
}
