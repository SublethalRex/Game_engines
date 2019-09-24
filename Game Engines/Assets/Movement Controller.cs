using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour

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
        
    }
}
