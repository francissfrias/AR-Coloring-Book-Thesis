using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooseAnimation : MonoBehaviour {

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

    public void eat()
    {
        anim.Play("G_eat", -1, 0f);
    }
    public void run()
    {
        anim.Play("G_run", -1, 0f);
    }


}