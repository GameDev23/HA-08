using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SwitchDavid()
    {
        SceneManager.LoadScene("DavidLevel");
    }
    
    public void SwitchMarvin()
    {
        SceneManager.LoadScene("MarvinLevel");
    }
    
    public void SwitchSamwel()
    {
        SceneManager.LoadScene("SamwelLevel");
    }
}
