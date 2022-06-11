using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public float speed = 1f;
    public float maxSpeed = 50f;

    void FixedUpdate()
    {
        HandleMovement();
    }

    void HandleMovement()
    {

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2d.AddForce(-transform.right * speed, ForceMode2D.Force);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidbody2d.AddForce(transform.right * speed, ForceMode2D.Force);
        }
        rigidbody2d.velocity = Vector2.ClampMagnitude(rigidbody2d.velocity, maxSpeed);

    }
}
