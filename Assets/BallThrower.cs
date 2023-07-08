using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrower : MonoBehaviour
{
    [SerializeField] private GameObject Ball;
    [SerializeField] private GameObject spawnPos;

    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            ThrowBall();
        }
    }

    private void ThrowBall()
    {
        GameObject ball = Instantiate(Ball);
        ball.transform.position = spawnPos.transform.position + Vector3.forward;
        Rigidbody rg = ball.GetComponent<Rigidbody>();

        Vector3 center = transform.position;
        center.y = ball.transform.position.y;
        ball.transform.position = spawnPos.transform.position + spawnPos.transform.forward * 1.5f;
        ball.transform.LookAt(center);
        
        rg.AddForce(cam.transform.forward * 1000f);
    }
}
