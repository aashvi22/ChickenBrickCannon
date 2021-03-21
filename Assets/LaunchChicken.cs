using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchChicken : MonoBehaviour
{

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update() { 
    
        
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.forward, ForceMode.Impulse);
            rb.useGravity = true;
        }
            
    }
}
