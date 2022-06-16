using UnityEngine;

namespace Interactables
{
    public class PlayAudioSourceOnPlayerEnter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                GetComponent<AudioSource>().Play();
            }
        }
    }
}
