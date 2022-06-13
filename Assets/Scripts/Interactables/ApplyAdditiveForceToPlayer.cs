using System;
using Enums;
using UnityEngine;

namespace Interactables
{
    public class ApplyAdditiveForceToPlayer : MonoBehaviour
    {
        private Rigidbody2D _playerRigidBody;
        public float externalForce;
        public ExternalMovePlayerDirection forceDirection;
        private const ForceMode2D ForceMode = ForceMode2D.Force;

        private void OnTriggerEnter2D(Collider2D col)
        {
            _playerRigidBody = col.GetComponent<Rigidbody2D>();
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            if (!other.CompareTag("Player")) return;
    
            switch (forceDirection)
            {
                case ExternalMovePlayerDirection.Upwards:
                    _playerRigidBody.AddForce(new Vector2(0, externalForce), ForceMode);
                    break;
                case ExternalMovePlayerDirection.Left:
                    _playerRigidBody.AddForce(new Vector2(-externalForce, 0), ForceMode);
                    break;
                case ExternalMovePlayerDirection.Right:
                    _playerRigidBody.AddForce(new Vector2(externalForce, 0), ForceMode);
                    break;
                case ExternalMovePlayerDirection.Downwards:
                    _playerRigidBody.AddForce(new Vector2(0, -externalForce), ForceMode);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}