using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressionFloat : ProgressionBase
{
    [SerializeField, Min(0f)] float value = 0f;

    public float Value
    {
        get
        {
            return value;
        }
    }

    public void Increment(float step = 1f)
    {
        value += step;
    }

    public void Decrement(float step = 1f)
    {
        value = Mathf.Clamp(value - step, 0f, float.MaxValue);
    }

    public void Set(float value)
    {
        this.value = Mathf.Clamp(value, 0, float.MaxValue);
    }

    public override void Reset()
    {
        value = 0f;
    }
}
