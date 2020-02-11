using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uWuhanAIControl : MonoBehaviour
{

    public float moveSpeed;
    public float turnSpeed;

    private Rigidbody rb;
    private Animator anim;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        turnSpeed = Random.Range(-1f,1f);
        //anim.SetFloat("Turn", turnSpeed);
        rb.MovePosition(new Vector3(moveSpeed, 0.0f, turnSpeed) + rb.position);

    }
}
