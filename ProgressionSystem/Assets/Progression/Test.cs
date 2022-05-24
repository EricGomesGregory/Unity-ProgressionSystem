using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] string tag;
    [SerializeField] ProgressionContainer container;
    [SerializeField] string display;

    ProgressionTime progression;

    private void Start()
    {
        if(container.TryGetProgressionTime(tag, out progression))
        {
            return;
        }
    }

    private void Update()
    {
        if (progression != null)
        {
            progression.Update();
            display = progression.ToString();
        }
    }
}
