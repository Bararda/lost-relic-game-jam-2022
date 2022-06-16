using System;
using Player;
using UnityEngine;

namespace Interactables
{
    public class OneTimeHitToPlayer : MonoBehaviour
    {
        public int damageOnHit;

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                GetComponent<BoxCollider2D>().enabled = false;
                GetComponent<SpriteRenderer>().enabled = false;
                col.GetComponent<HealthObserver>().Hit(damageOnHit);

                AudioSource audioSource = GetComponent<AudioSource>();
                if (audioSource != null)
                {
                    audioSource.Play();
                    Destroy(gameObject, audioSource.clip.length);
                }
                else
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
