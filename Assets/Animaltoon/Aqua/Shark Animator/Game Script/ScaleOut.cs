using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleOut : MonoBehaviour {

    public GameObject Object;
    private bool _ZoomIn;
    private bool _ZoomOut;

    //object scale speed;
    public float Scale = 0.1f;

    void Start()
    {

    }
    void Update()
    {
        if (_ZoomIn)
        {
            Object.transform.localScale += new Vector3(Scale, Scale, Scale);
        }
        if (_ZoomOut)
        {
            Object.transform.localScale -= new Vector3(Scale, Scale, Scale);

        }
    }
    public void OnpressZoomIn()
    {
        _ZoomIn = true;
    }
    public void OnpressZoomOut()
    {
        _ZoomOut = true;
    }
    public void OnReleaseZoomIn()
    {
        _ZoomIn = false;
    }
    public void OnReleaseZoomOut()
    {
        _ZoomOut = false;
    }

}
