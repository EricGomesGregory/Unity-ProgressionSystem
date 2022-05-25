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
        GUILayout.Space(20f);
        GUILayout.Label("Progression Elements");

        if(GUILayout.Button("Bool"))
        { myTarget.progressions.Add(new ProgressionBool()); }

        if (GUILayout.Button("Counter"))
        { myTarget.progressions.Add(new ProgressionCounter()); }

        if (GUILayout.Button("Time"))
        { myTarget.progressions.Add(new ProgressionTime()); }

        if (GUILayout.Button("String"))
        { myTarget.progressions.Add(new ProgressionString()); }
    }
}
