using UnityEngine;

namespace Interactables
{
   public class PlayAnimationOnPlayerEnter : MonoBehaviour
   {
      private void OnTriggerEnter2D(Collider2D col)
      {
         if (col.CompareTag("Player"))
         {
            GetComponent<Animator>().Play("Jump");
         }
      }
   }
}
