using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectUp : MonoBehaviour {

    public GameObject objectRotate1;

    public float rotateSpeed1 = 50f;
    bool rotateStatus1 = false;

    void Start()
    {
      
    }
    public void OnpressRotate1()
    {

            if (rotateStatus1 == false)
            {
                rotateStatus1 = true;
            }
            else
            {
                rotateStatus1 = false;
            }
        
    }
     
    public void OnReleaseRotate1()
    {
        if (rotateStatus1 == true)
        {
            rotateStatus1 = false;
        }
        else
        {
            rotateStatus1 = true;
        }
    }
    void Update()
    {
        if (rotateStatus1 == true)
        {
            objectRotate1.transform.Rotate(Vector3.left, rotateSpeed1 + Time.deltaTime);
        }
    
        
    }
}
