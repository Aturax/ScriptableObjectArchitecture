using UnityEngine;

[CreateAssetMenu(fileName = "new Float Variable", menuName = "Data/Float variable", order = 1)]
public class FloatVariable : ScriptableObject
{
    public float InitialValue = 0f;

    float _value = 0f;

    public event System.Action OnValueChanged = () => {};

    public float Value
    {
        get => _value;
        set
        {
            _value = value;
            OnValueChanged();
        }
    }

    private void OnEnable()
    {
        _value = InitialValue;
    }
}
