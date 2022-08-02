using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private float moveInput;
    public Animator animator;
    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
    }
}
