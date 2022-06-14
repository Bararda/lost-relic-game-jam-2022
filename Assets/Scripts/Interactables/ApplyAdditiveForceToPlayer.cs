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
        public bool ignoreMass = false;
        private const ForceMode2D ForceMode = ForceMode2D.Force;

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                _playerRigidBody = col.GetComponent<Rigidbody2D>();
            }
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            if (!other.CompareTag("Player")) return;
            
            float force = ignoreMass ? externalForce * _playerRigidBody.mass : externalForce;
            
            switch (forceDirection)
            {
                case ExternalMovePlayerDirection.Upwards:
                    _playerRigidBody.AddForce(new Vector2(0, force), ForceMode);
                    break;
                case ExternalMovePlayerDirection.Left:
                    _playerRigidBody.AddForce(new Vector2(-force, 0), ForceMode);
                    break;
                case ExternalMovePlayerDirection.Right:
                    _playerRigidBody.AddForce(new Vector2(force, 0), ForceMode);
                    break;
                case ExternalMovePlayerDirection.Downwards:
                    _playerRigidBody.AddForce(new Vector2(0, -force), ForceMode);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}