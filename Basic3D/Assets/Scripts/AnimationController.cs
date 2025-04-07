using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isRotate", true);
            animator.SetBool("isScale", false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isScale", true);
            animator.SetBool("isRotate", false);
        }
        else
        {
            animator.SetBool("isScale", false);
            animator.SetBool("isRotate", false);

        }
    }
}
