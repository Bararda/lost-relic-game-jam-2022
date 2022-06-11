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
        float movementVertical = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;
        rigidbody2d.velocity = new Vector2(movementHorizontal, movementVertical);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }
}
