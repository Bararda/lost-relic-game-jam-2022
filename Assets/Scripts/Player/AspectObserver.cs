using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AspectObserver : MonoBehaviour, IObserver
{
    public Aspect aspect;
    public bool isInverted = false;

    void Start()
    {
        aspect.Attach(this);
    }
    public virtual void OnNotify()
    {
        Debug.Log("Aspect On Notify Not Implemented");
    }

    public float GetAspectValue()
    {
        if (isInverted)
        {
            return (float)((aspect.maxValue - aspect.value));
        }
        else
        {
            return (float)(aspect.value);
        }
    }
}
