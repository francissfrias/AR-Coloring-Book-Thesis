using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabAnimation : MonoBehaviour {


    private Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {



    }

    public void run()
    {
        anim.Play("Crab_Run", -1, 0f);
    }
    public void sleep()
    {
        anim.Play("Crab_Sleep", -1, 0f);
    }
   
  
}