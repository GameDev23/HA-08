using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateCreater : MonoBehaviour
{
    
    [SerializeField] private GameObject[] Crates;
    [SerializeField] private GameObject pos;
    private bool isHoldingCrate = false;
    public int currentIndex = 0;
    private GameObject Crate;

    private LayerMask mask;
    // Start is called before the first frame update
    void Start()
    {
        mask = LayerMask.GetMask("Crate");
        pos.transform.position += transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Crate handling
            HandleCrate();
        }

        if (Input.GetButtonUp("Fire1"))
        {
            if (isHoldingCrate)
            {
                isHoldingCrate = false;
                Crate.GetComponent<Rigidbody>().isKinematic = false;
            }
        }

        if (Input.GetButtonDown("Key1"))
        {
            currentIndex = 0;
        }
        if (Input.GetButtonDown("Key2"))
        {
            currentIndex = 1;
        }
        if (Input.GetButtonDown("Key3"))
        {
            currentIndex = 2;
        }
        if (Input.GetButtonDown("Key4"))
        {
            currentIndex = 3;
        }
        if (Input.GetButtonDown("Key5"))
        {
            currentIndex = 4;
        }

        if (isHoldingCrate && Crate != null)
        {
            Vector3 center = transform.position;
            center.y = Crate.transform.position.y;
            Crate.transform.position = pos.transform.position + pos.transform.forward * 2;
            Crate.transform.LookAt(center);
        }
    }

    void HandleCrate()
    {
        Ray ray = new Ray(pos.transform.position, pos.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 3f) && hit.transform.CompareTag("Crate"))
        {

            
            Debug.Log("Found a crate here");
            GameObject crate = hit.collider.attachedRigidbody.gameObject;
            crate.transform.position = pos.transform.position;
            isHoldingCrate = true;
            Crate = crate;
            
        }
        else
        {
            GameObject crate = Instantiate(Crates[currentIndex]);
            crate.transform.position = pos.transform.position;
            isHoldingCrate = true;
            Crate = crate;
        }

        Crate.GetComponent<Rigidbody>().isKinematic = true;

    }
}