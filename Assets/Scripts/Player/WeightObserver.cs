using UnityEngine;

namespace Player
{
    public class WeightObserver : AspectObserver
    {
        public Rigidbody2D rb2d;

        public override void OnNotify()
        {
            rb2d.mass = GetAspectValue();
        }
    }
}
