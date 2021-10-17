using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject1 : MonoBehaviour {

    public GameObject objectRotate;

    public float rotateSpeed = 50f;
    bool rotateStatus = false;

    void Start()
    {
      
    }
    public void OnpressRotate()
    {

            if (rotateStatus == false)
            {
                rotateStatus = true;
            }
            else
            {
                rotateStatus = false;
            }
        
    }
     
    public void OnReleaseRotate()
    {
        if (rotateStatus == true)
        {
            rotateStatus = false;
        }
        else
        {
            rotateStatus = true;
        }
    }
    void Update()
    {
        if (rotateStatus == true)
        {
            objectRotate.transform.Rotate(Vector3.up, rotateSpeed + Time.deltaTime);
        }
    
        
    }
}
