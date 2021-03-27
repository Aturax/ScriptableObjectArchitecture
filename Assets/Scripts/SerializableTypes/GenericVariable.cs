using UnityEngine;

public class GenericVariable<T> : ScriptableObject
{
    public T InitialValue = default;

    T _value = default;

    public event System.Action OnValueChanged = () => { };

    public T Value
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