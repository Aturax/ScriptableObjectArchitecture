using UnityEngine;
using UnityEngine.UI;

public class PlayerUIImage : MonoBehaviour
{
    [SerializeField] Image _image = null;
    [SerializeField] FloatVariable _playerHealth = null;

    float _initial = 0f;
    void Start()
    {
        _initial = _playerHealth.Value;
        ShowHealth();
        _playerHealth.OnValueChanged += ShowHealth;
    }

    public void ShowHealth()
    {
        _image.fillAmount = _playerHealth.Value / _initial;
    }
}
