using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ProgressionString : ProgressionBase
{
    [SerializeField] string value;

    public string Value
    {
        get
        {
            return value;
        }
        set
        {
            this.value = value;
        }
    }

    public bool Equals(string other)
    {
        return value == other;
    }
}
