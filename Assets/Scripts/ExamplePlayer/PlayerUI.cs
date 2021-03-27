using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] FloatVariable playerHealth = null;
    [SerializeField] TMPro.TMP_Text healthText = null;

    [SerializeField] IntVariable coins = null;
    [SerializeField] TMPro.TMP_Text coinsText = null;

    [SerializeField] BoolVariable injuried = null;
    [SerializeField] TMPro.TMP_Text injuriedText = null;

    [SerializeField] StringVariable playerName = null;
    [SerializeField] TMPro.TMP_Text playerNameText = null;

    void Start()
    {
        ShowHealth();
        playerHealth.OnValueChanged += ShowHealth;

        ShowCoins();
        coins.OnValueChanged += ShowCoins;

        ShowInjuried();
        injuried.OnValueChanged += ShowInjuried;

        ShowName();
        playerName.OnValueChanged += ShowName;

    }

    public void ShowHealth()
    {
        healthText.text = "Health: " + playerHealth.Value;
    }

    public void ShowCoins()
    {
        coinsText.text = "Coins: " + coins.Value;
    }

    public void ShowInjuried()
    {
        injuriedText.text = "Injuried: " + injuried.Value;
    }

    public void ShowName()
    {
        playerNameText.text = "Player: " + playerName.Value;
    }
}
