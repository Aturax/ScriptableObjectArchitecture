using UnityEngine;

[CreateAssetMenu(fileName = "new Int Variable", menuName = "Data/Int variable", order = 2)]
public class IntVariable : ScriptableObject
{
    public int InitialValue = 0;

    int _value = 0;

    public event System.Action OnValueChanged = () => { };

    public int Value
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
