using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ProgressionContainer))]
public class ProgressionContainerEditor : Editor
{
    ProgressionContainer myTarget;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        myTarget = (ProgressionContainer)target;

        DisplayButtons();
    }

    private void DisplayButtons()
    {
        if(GUILayout.Button("Add Bool"))
        { myTarget.progressions.Add(new ProgressionBool()); }

        if (GUILayout.Button("Add Counter"))
        { myTarget.progressions.Add(new ProgressionCounter()); }

        if (GUILayout.Button("Add Time"))
        { myTarget.progressions.Add(new ProgressionTime()); }
    }
}
