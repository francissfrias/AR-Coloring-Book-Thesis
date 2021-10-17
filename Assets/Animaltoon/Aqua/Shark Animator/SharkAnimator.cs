using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkAnimator : MonoBehaviour {

    private Animator sharkanim;

	// Use this for initialization
	void Start () {
        sharkanim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

       

	}

    public void SharkFastSwim ()
    {
        sharkanim.Play("fastswim",-1, 0f);
    }
    public void SharkEat()
    {
        sharkanim.Play("attack", -1, 0f);
    }
}
