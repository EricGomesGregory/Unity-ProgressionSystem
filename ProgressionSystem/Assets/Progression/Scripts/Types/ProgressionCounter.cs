using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ProgressionCounter : ProgressionBase
{
    [SerializeField, Min(0)] int value;

    public int Value
    {
        get
        {
            return value;
        }
    }

    public ProgressionCounter(int value=0)
    {
        this.value = value;
    }

    public void Increment()
    {
        value++;
    }

    public void Decrement()
    {
        value = Mathf.Clamp(value -1, 0, int.MaxValue);
    }

    public void Set(int value)
    {
        this.value = Mathf.Clamp(value, 0, int.MaxValue);
    }

    public override void Reset()
    {
        value = 0;
    }
}
