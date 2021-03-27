using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(IntVariable))]
public class IntVariableEditor : Editor
{
    public override void OnInspectorGUI()
    {
        IntVariable intTarget = (IntVariable)target;
        if (Application.isPlaying)
        {
            intTarget.Value = EditorGUILayout.IntField("Runtime Value", intTarget.Value);
            if (GUILayout.Button("Save"))
            {
                intTarget.InitialValue = intTarget.Value;
            }
        }
        else
        {
            intTarget.InitialValue = EditorGUILayout.IntField("Value", intTarget.InitialValue);
        }
    }
}