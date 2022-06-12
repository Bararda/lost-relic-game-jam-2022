using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightObserver : AspectObserver
{
    public Rigidbody2D rb2d;

    public override void OnNotify()
    {
        rb2d.mass = GetAspectValue();
    }
}