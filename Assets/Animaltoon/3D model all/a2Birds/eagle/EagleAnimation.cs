using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleAnimation : MonoBehaviour {

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

    public void at()
    {
        anim.Play("Eagle_Attack", -1, 0f);
    }
    public void fly()
    {
        anim.Play("Eagle_Leave", -1, 0f);
    }


}