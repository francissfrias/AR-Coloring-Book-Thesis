using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluejayAnimations : MonoBehaviour {
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

    public void fly()
    {
        anim.Play("flyStraight", -1, 0f);
    }
    public void Hop()
    {
        anim.Play("hopBack", -1, 0f);
    }


}