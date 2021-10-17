using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerAnimation : MonoBehaviour {

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

    public void attack()
    {
        anim.Play("Tiger_Hit", -1, 0f);
    }
    public void eat()
    {
        anim.Play("Tiger_Roar", -1, 0f);
    }
    public void run()
    {
        anim.Play("Tiger_run", -1, 0f);
    }
}
