using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(FloatVariable))]
public class FloatVariableEditor : Editor
{
    public override void OnInspectorGUI()
    {
        FloatVariable floatTarget = (FloatVariable)target;
        if(Application.isPlaying)
        {
            floatTarget.Value = EditorGUILayout.FloatField("Runtime Value", floatTarget.Value);
            if (GUILayout.Button("Save"))
            {
                floatTarget.InitialValue = floatTarget.Value;
            }
        }
        else
        {
            floatTarget.InitialValue = EditorGUILayout.FloatField("Value", floatTarget.InitialValue);
        }
    }
}