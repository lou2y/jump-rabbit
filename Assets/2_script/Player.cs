using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float JumpPower = 0;

    private Rigidbody2D rigd;
    private Animator anim;

    private void Awake()
    {
        rigd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    public void init()
    {
      
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetInteger("StateID", 1);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            JumpPower += 1;
        }
        else if (Input.GetKeyUp(KeyCode.Space)) 
        {
            rigd.AddForce(Vector2.one * JumpPower);
            JumpPower = 0;

            anim.SetInteger("StateID", 2);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigd.velocity = Vector2.zero;
        anim.SetInteger("StateID", 0);
    }
}
