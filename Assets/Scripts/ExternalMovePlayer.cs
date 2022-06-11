using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ExternalMovePlayer : MonoBehaviour
{
    private Rigidbody2D _playerRigidBody;
    public float externalForce;
    public ExternalMovePlayerDirection forceDirection;

    public enum ExternalMovePlayerDirection
    {
        Upwards,
        Downwards,
        Left, 
        Right
    }
    
    private void Start()
    {
        _playerRigidBody = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        
        switch (forceDirection)
        {
            case ExternalMovePlayerDirection.Upwards:
                _playerRigidBody.AddForce(new Vector2(0, externalForce), ForceMode2D.Force);
                break;
            case ExternalMovePlayerDirection.Left:
                _playerRigidBody.AddForce(new Vector2(-externalForce, 0), ForceMode2D.Force);
                break;
            case ExternalMovePlayerDirection.Right:
                _playerRigidBody.AddForce(new Vector2(externalForce, 0), ForceMode2D.Force);
                break;
            case ExternalMovePlayerDirection.Downwards:
                _playerRigidBody.AddForce(new Vector2(0, -externalForce), ForceMode2D.Force);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
