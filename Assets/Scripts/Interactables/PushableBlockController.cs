using Enums;
using UnityEngine;

namespace Interactables
{
    public class PushableBlockController : MonoBehaviour
    {
        public PushableBlock leftBlock;
        public PushableBlock rightBlock;
        public float massRequirement;
        public float blockMoveSpeed;

        private void Awake()
        {
            //Due to how these assignments are made changing the block mass requirement at runtime will NOT effect the push requirement
            leftBlock.massRequirement = massRequirement;
            leftBlock.directionToMove = BlockDirection.Right;
            leftBlock.blockMoveSpeed = blockMoveSpeed;
            rightBlock.massRequirement = massRequirement;
            rightBlock.directionToMove = BlockDirection.Left;
            rightBlock.blockMoveSpeed = blockMoveSpeed;
        }
    }
}
