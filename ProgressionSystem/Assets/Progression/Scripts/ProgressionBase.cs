using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ProgressionBase
{
    [SerializeField] string name;

    public string Name
    {
        get
        {
            return name;
        }
    }

    public virtual void Reset() { }
}