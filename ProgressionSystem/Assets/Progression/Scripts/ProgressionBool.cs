using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ProgressionBool : ProgressionBase
{
    [SerializeField] bool value;

    public bool Value
    {
        get
        {
            return value;
        }
    }

    public void Trigger()
    {
        value = true;
    }

    public override void Reset()
    {
        value = false;
    }
}
