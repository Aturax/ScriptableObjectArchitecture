using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(StringVariable))]
public class StringVariableEditor : Editor
{
    public override void OnInspectorGUI()
    {
        StringVariable stringTarget = (StringVariable)target;
        if (Application.isPlaying)
        {
            stringTarget.Value = EditorGUILayout.TextField("Runtime Value", stringTarget.Value);
            if (GUILayout.Button("Save"))
            {
                stringTarget.InitialValue = stringTarget.Value;
            }
        }
        else
        {
            stringTarget.InitialValue = EditorGUILayout.TextField("Value", stringTarget.InitialValue);
        }
    }
}