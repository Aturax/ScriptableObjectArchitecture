using UnityEngine;

[CreateAssetMenu(fileName = "new Bool Variable", menuName = "Data/Bool variable", order = 3)]
public class BoolVariable : ScriptableObject
{
    public bool InitialValue = false;

    bool _value = false;

    public event System.Action OnValueChanged = () => { };

    public bool Value
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