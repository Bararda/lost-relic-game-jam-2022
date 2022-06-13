using UnityEngine;
using UnityEngine.Events;

namespace Player
{
    public class HealthObserver : AspectObserver
    {
        public int hitpoints = 5;
        public int damageTaken = 0;
        public UnityEvent onDeath;
        public override void OnNotify()
        {
            hitpoints = (int)GetAspectValue();
            CheckHealth();
        }

        public void Hit(int damage)
        {
            damageTaken += damage;
            CheckHealth();
        }

        void CheckHealth()
        {
            if (hitpoints - damageTaken <= 0)
            {
                Debug.Log("Player died");
                onDeath.Invoke();
            }
        }
    }
}
