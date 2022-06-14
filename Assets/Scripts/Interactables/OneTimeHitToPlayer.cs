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
                col.GetComponent<HealthObserver>().Hit(damageOnHit);
                Destroy(gameObject);
            }
        }
    }
}
