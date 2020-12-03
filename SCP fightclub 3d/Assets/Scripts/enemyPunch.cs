using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPunch : MonoBehaviour
{
    public GameObject fist;
    public GameObject kick;
    public Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.E) == true)
        {
            fist.SetActive(true);
            animator.SetBool("punch", true);
        }
        else
        {
            fist.SetActive(false);
            animator.SetBool("punch", false);
        }

        if (Input.GetKey(KeyCode.Q) == true)
        {
            kick.SetActive(true);
            animator.SetBool("punch", true);
        }
        else
        {
            kick.SetActive(false);
            animator.SetBool("kick", false);
        }
    }
}
