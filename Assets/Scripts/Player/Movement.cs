using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public float speed = 100f;

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        float movementHorizontal = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        rigidbody2d.velocity = new Vector2(movementHorizontal, 0);
    }
}
