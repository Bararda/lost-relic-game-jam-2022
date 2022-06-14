namespace Player
{
    public class SpeedObserver : AspectObserver
    {
        public Movement movement;
        public override void OnNotify()
        {
            movement.maxSpeed = GetAspectValue() * 2;
            movement.speed = GetAspectValue() * 100;
        }
    }
}
