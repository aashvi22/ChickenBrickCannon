using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateChicken : MonoBehaviour
{
    
    public GameObject myPrefab;
    GameObject chicken;
    Rigidbody rb;
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            chicken = Instantiate(myPrefab, GameObject.Find("Gun_End").transform.position + new Vector3(0, 0, 0.5f), transform.rotation);
            rb = chicken.GetComponent<Rigidbody>();
            chicken.AddComponent<BoxCollider>();
            chicken.GetComponent<BoxCollider>().size = new Vector3(0.5f, 0.5f, 0.5f);
            rb.isKinematic = false;
            rb.AddForce(GameObject.Find("Gun_End").transform.up*-20f, ForceMode.Impulse);
            rb.useGravity = true;
        }
    }
}
