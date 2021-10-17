using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ibexanimator : MonoBehaviour {

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
        anim.Play("Ibex_attack", -1, 0f);
    }
    public void eat()
    {
        anim.Play("Ibex_eat", -1, 0f);
    }
    public void run()
    {
        anim.Play("Ibex_run", -1, 0f);
    }
}