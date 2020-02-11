using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public Transform player;
    public float moveSpeed;
    private Rigidbody rb;
    private Vector3 movement;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.z, direction.x) * Mathf.Rad2Deg;
        rb.MoveRotation(Quaternion.Euler(new Vector3(0.0f, angle, 0.0f)));
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate() {
        moveEnemy(movement);
    }

    void moveEnemy(Vector3 direction)
    {
        rb.MovePosition(transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
