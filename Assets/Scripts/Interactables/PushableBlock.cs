using Enums;
using Player;
using UnityEngine;

namespace Interactables
{
    public class PushableBlock : MonoBehaviour
    {
        internal float massRequirement;
        internal BlockDirection directionToMove;
        private int DirectionOperand => directionToMove == BlockDirection.Left ? -1 : 1;
        internal float blockMoveSpeed;

        private void OnTriggerStay2D(Collider2D other)
        {

            if (other.CompareTag("Player") && other.GetComponent<Rigidbody2D>().mass >= massRequirement)
            {
                Transform cachedTransform = transform.parent;
                Vector3 position = cachedTransform.position;
                position = new Vector3(position.x + (DirectionOperand * blockMoveSpeed), position.y, 0);
                cachedTransform.position = position;
            }
        }
    }
}
