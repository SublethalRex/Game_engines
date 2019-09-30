using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{


    public Animator anim;
    public float speed = 3.5f;


    // Start is called before the first frame update
    void Start()
    {

        if (anim == null) anim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w"))
        {
            anim.SetFloat(name: "Verticle", speed);

        }
        else if (Input.GetKey("s"))
        {

            anim.SetFloat("Verticle", -speed);

        }
        else
        {

            anim.SetFloat(name: "Verticle", 0);
        }

        if (Input.GetKey("a"))
        {
            anim.SetFloat("Horizontal", -speed);


        }
        else if (Input.GetKey("d"))
        {
            anim.SetFloat("Horizontal", speed);


        }
        else
        {
            anim.SetFloat("Horizontal", 0);


        }

        if (Input.GetKey("shift"))
        {
            anim.SetBool("Sprinting", true);

        }


    }
}
