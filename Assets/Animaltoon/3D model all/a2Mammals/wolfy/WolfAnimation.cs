using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAnimation : MonoBehaviour {

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
        anim.Play("Wolf_attack", -1, 0f);
    }
    public void eat()
    {
        anim.Play("Wolf_eat", -1, 0f);
    }
    public void run()
    {
        anim.Play("Wolf_run", -1, 0f);
    }
    public void howl()
    {
        anim.Play("Wolf_howl", -1, 0f);
    }
}