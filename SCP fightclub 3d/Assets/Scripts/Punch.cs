﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    public GameObject fist;
    public GameObject kick;
    public Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) == true)
        {
            fist.SetActive(true);
            animator.SetBool("punch", true);
        }
        else
        { 
            fist.SetActive(false) ;
            animator.SetBool("punch", false); 
        }

        if (Input.GetKey(KeyCode.RightShift) == true)
        {
            kick.SetActive(true);
            animator.SetBool("kick", true);
        }
        else
        {
            kick.SetActive(false);
            animator.SetBool("kick", false);
        }
    }
}
