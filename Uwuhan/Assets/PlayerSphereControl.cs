using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSphereControl : MonoBehaviour
{
    public GameObject logic;
    public float speed;
    public float boost;
    public float jumpHeight;
    private float defaultYpos;
    private Vector3 movement;
    private Rigidbody rb;
    private float defaultSpeed;
    private float defaultBoost;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        defaultYpos = rb.position.y;
        defaultSpeed = speed;
        defaultBoost = boost;
    }

    void Update () {
        if (Input.GetKey("z"))
        {
            rb.AddForce(this.movement * boost);
        }
        if (Input.GetKey("x") && rb.position.y == defaultYpos)
        {
            rb.AddForce(new Vector3(this.movement.x, jumpHeight, this.movement.z));
        }

    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        this.movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(this.movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            GameLogic.IncrementPills();
        }
        else if (other.gameObject.CompareTag("Boost"))
        {
            this.speed = 10.0f;
            this.boost = 20.0f;
        }
        else if (other.gameObject.CompareTag("Portal"))
        {
            this.speed = defaultSpeed;
            this.boost = defaultBoost;
        }
    }
}
