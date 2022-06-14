using System;
using Enums;
using UnityEngine;

namespace Interactables
{
    public class ApplyConstantForceToPlayer : MonoBehaviour
    {
        private ConstantForce2D _playerConstantForce;
        public float externalForce;
        public bool ignoreMass = false;
        public ExternalMovePlayerDirection forceDirection;
        private const ForceMode2D ForceMode = ForceMode2D.Impulse;

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                _playerConstantForce = col.GetComponent<ConstantForce2D>();
            }
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            if (!other.CompareTag("Player")) return;
            float force = externalForce;
            if (ignoreMass)
            {
                force *= other.GetComponent<Rigidbody2D>().mass;
            }
            switch (forceDirection)
            {
                case ExternalMovePlayerDirection.Upwards:
                    _playerConstantForce.force = new Vector2(0, force);
                    break;
                case ExternalMovePlayerDirection.Left:
                    _playerConstantForce.force = new Vector2(-force, 0);
                    break;
                case ExternalMovePlayerDirection.Right:
                    _playerConstantForce.force = new Vector2(force, 0);
                    break;
                case ExternalMovePlayerDirection.Downwards:
                    _playerConstantForce.force = new Vector2(0, -force);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                _playerConstantForce.force = new Vector2(0, 0);
            }
        }
    }
}
