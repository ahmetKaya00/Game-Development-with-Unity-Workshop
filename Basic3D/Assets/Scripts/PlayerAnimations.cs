using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
            animator.SetBool("isIdle", false);
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("isRunning", true);
            animator.SetBool("isIdle", false);

        }
        else
        {
            animator.SetBool("isRunning", false);
            animator.SetBool("isWalking", false);
            animator.SetBool("isIdle", true);

        }
    }
}
