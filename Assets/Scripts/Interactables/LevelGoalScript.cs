using UnityEngine;

namespace Interactables
{
    public class LevelGoalScript : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                Debug.Log("Player entered the Goal");
            }
        }
    }
}
