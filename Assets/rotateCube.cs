using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCube : MonoBehaviour
{
    Vector3 positionForRotation;
    void Start()
    {
        positionForRotation = transform.position-transform.localScale*0.75f;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.RotateAround(positionForRotation, new Vector3(1, 0, 0), -1.0f);
        if(Input.GetKey(KeyCode.RightArrow))
            transform.RotateAround(positionForRotation, new Vector3(1, 0, 0), 1.0f);
        
    }
}
