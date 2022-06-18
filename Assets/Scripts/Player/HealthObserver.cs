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
            int currentHitpoints = hitpoints;
            hitpoints = (int)GetAspectValue();
            EnforceAspectMinimum(currentHitpoints);
            CheckHealth();
        }

        void EnforceAspectMinimum(int currentHitpoints)
        {
            if (CurrentHealth <= 0)
            {
                if (isInverted)
                {
                    aspect.SetAspectValue(aspect.maxValue - currentHitpoints);
                }
                else
                {
                    aspect.SetAspectValue(currentHitpoints);
                }
            }
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
            SetHealthText();
            if (CurrentHealth <= 0)
            {
                Debug.Log("Player died");
                onDeath.Invoke();
            }
        }

        private void SetHealthText()
        {
            if (!isInverted)
            {
                aspect.topText.text = (CurrentHealth).ToString();
            }
            else
            {
                aspect.bottomText.text = (CurrentHealth).ToString();
            }
        }
    }
}
