using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ProgressionBase
{
    [HideInInspector]
    public string name => tag;

    [SerializeField] string tag;

    public string Tag
    {
        get
        {
            return tag;
        }
    }
}