using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(BoolVariable))]
public class BoolVariableEditor : Editor
{
    public override void OnInspectorGUI()
    {
        BoolVariable boolTarget = (BoolVariable)target;
        if (Application.isPlaying)
        {
            boolTarget.Value = EditorGUILayout.Toggle("Runtime Value", boolTarget.Value);
            if (GUILayout.Button("Save"))
            {
                boolTarget.InitialValue = boolTarget.Value;
            }
        }
        else
        {
            boolTarget.InitialValue = EditorGUILayout.Toggle("Value", boolTarget.InitialValue);
        }
    }
}