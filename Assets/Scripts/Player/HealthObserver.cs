using UnityEngine;
using UnityEngine.Events;

namespace Player
{
    public class HealthObserver : AspectObserver
    {
        public int hitpoints = 5;
        public int damageTaken = 0;
        public UnityEvent onDeath;
        private int CurrentHealth => hitpoints - damageTaken;

        public override void OnNotify()
        {
            hitpoints = (int)GetAspectValue();
            CheckHealth();
        }

        public void Hit(int damage)
        {
            damageTaken += damage;
            Debug.Log($"Damage Taken: {damageTaken}");
            Debug.Log($"Current Health: {CurrentHealth}");
            CheckHealth();
        }

        private void CheckHealth()
        {
            if (CurrentHealth <= 0)
            {
                Debug.Log("Player died");
                onDeath.Invoke();
            }
        }
    }
}
