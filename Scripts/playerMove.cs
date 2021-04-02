using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    Transform player_tr;
    Animator anim;
    Rigidbody rb;
    float v;
    void Start()
    {
        player_tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        v = Input.GetAxis("Vertical");
        rb.velocity = transform.forward * v;
        anim.SetFloat("run", v);
        if(Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger("attack");
        }
        if(Input.GetButton("Fire2"))
        {
            anim.SetBool("guard", true);
        }else
        {
            anim.SetBool("guard", false);
        }
        if(Input.GetKeyDown("space"))
        {
            anim.SetTrigger("jump");
        }
    }
    public void GetRotate(float arg)
    {
        player_tr.rotation = Quaternion.Euler(0,arg,0);
    }
}
