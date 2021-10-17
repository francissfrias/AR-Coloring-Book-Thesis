using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bearanimator : MonoBehaviour {

    // Use this for initialization
    private Animator bearanim;

    // Use this for initialization
    void Start()
    {
        bearanim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {



    }

    public void Bearattack()
    {
        bearanim.Play("Bear_attack", -1, 0f);
    }
    public void Beareat()
    {
        bearanim.Play("Bear_eat", -1, 0f);
    }
    public void Bearrun()
    {
        bearanim.Play("Bear_run", -1, 0f);
    }
}

