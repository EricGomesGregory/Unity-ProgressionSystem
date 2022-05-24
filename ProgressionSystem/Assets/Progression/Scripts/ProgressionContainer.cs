using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Progression/Container", fileName = "new Progression Container")]
public class ProgressionContainer : ScriptableObject
{
    [SerializeReference]
    public List<ProgressionBase> progressions = new List<ProgressionBase>();

    [Header("Debug")]
    [SerializeField] bool resetOnPlay = true;

    Dictionary<string, int> dictionary;


    private void OnValidate()
    {
        if (progressions == null) return;

        dictionary = new Dictionary<string, int>();

        for (int i = 0; i < progressions.Count; i++)
        {
            ProgressionBase element = progressions[i];
            dictionary.Add(element.Name, i);
        }
    }

    private void OnEnable()
    {
        if(resetOnPlay)
        {
            foreach (var element in progressions)
            {
                if (element is ProgressionBool)
                {
                    ProgressionBool temp = (ProgressionBool)element;
                    temp.Reset();
                }
                else if (element is ProgressionCounter)
                {
                    ProgressionCounter temp = (ProgressionCounter)element;
                    temp.Reset();
                }
                else if (element is ProgressionTime)
                {
                    ProgressionTime temp = (ProgressionTime)element;
                    temp.Reset();
                }
            }
        }
    }

    private bool TryGetProgression(string name, out ProgressionBase element)
    {
        element = null;
        int i;

        if(dictionary.TryGetValue(name, out i))
        {
            element = progressions[i];
            return true;
        }

        return false;
    }

    public bool TryGetProgressionBool(string name, out ProgressionBool element)
    {
        element = null;

        ProgressionBase temp;
        if(TryGetProgression(name, out temp))
        {
            if (temp is ProgressionBool)
            {
                element = (ProgressionBool)temp;
                return true;
            }
        }

        return false;
    }

    public bool TryGetProgressionCounter(string name, out ProgressionCounter element)
    {
        element = null;

        ProgressionBase temp;
        if (TryGetProgression(name, out temp))
        {
            if (temp is ProgressionBool)
            {
                element = (ProgressionCounter)temp;
                return true;
            }
        }

        return false;
    }

    public bool TryGetProgressionTime(string name, out ProgressionTime element)
    {
        element = null;

        ProgressionBase temp;
        if (TryGetProgression(name, out temp))
        {
            if (temp is ProgressionTime)
            {
                element = (ProgressionTime)temp;
                return true;
            }
        }

        return false;
    }
}
