using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private float moveInput;
    public Animator animator;
    private float _nextpunch = 0.15f;
    private float _punchDelay = 1;
    private string hori = "Horizontal";
    void Start(){
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        PunchAni();
        animator.SetFloat("Horizontal", Input.GetAxis(hori));
    }
    void PunchAni(){
        if(Input.GetMouseButtonDown(0) && Time.time > _nextpunch){
            hori = "Vertical";
            StartCoroutine(PunchAniTime());
            _nextpunch = Time.time + _punchDelay;
        }
    }
    IEnumerator PunchAniTime()
    {
        animator.SetBool("Punch", true);
        yield return new WaitForSeconds(1.3f);
        hori = "Horizontal";
        animator.SetBool("Punch", false);
        animator.SetFloat("Horizontal", 0);
    }
}
