using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbitanim : MonoBehaviour {

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
        anim.Play("WildRabbit_eat", -1, 0f);
    }
    public void run()
    {
        anim.Play("WildRabbit_run", -1, 0f);
    }
}