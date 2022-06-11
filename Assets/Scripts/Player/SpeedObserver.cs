using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedObserver : AspectObserver
{
    public Movement movement;
    public override void OnNotify()
    {
        movement.maxSpeed = GetAspectValue() * 10;
    }
}
