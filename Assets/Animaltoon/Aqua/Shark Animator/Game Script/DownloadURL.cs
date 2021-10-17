using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownloadURL : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void Download2D()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/13tfN2POk0edzdIYSxnppBrYrSOqiNlhd?usp=sharing");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
