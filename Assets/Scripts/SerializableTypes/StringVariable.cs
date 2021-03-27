using UnityEngine;

[CreateAssetMenu(fileName = "new String Variable", menuName = "Data/String variable", order = 4)]
public class StringVariable : ScriptableObject
{
    public string InitialValue = null;

    string _value = null;

    public event System.Action OnValueChanged = () => { };

    public string Value
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
