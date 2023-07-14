using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                transform.Rotate(1000f * Time.deltaTime,1000f * Time.deltaTime,0f );
        
    }
}
