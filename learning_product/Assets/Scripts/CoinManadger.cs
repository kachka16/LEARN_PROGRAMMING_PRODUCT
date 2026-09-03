using UnityEngine;
using TMPro;

public class CoinManadger : MonoBehaviour
{
    public TextMeshProUGUI[] coinsText;
    public static CoinManadger instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateCoinsText();
    }

    public void UpdateCoinsText()
    {
        int coins = PlayerPrefs.GetInt("Coins", 0);

        for (int i = 0; i < coinsText.Length; i++)
        {
            if (coinsText[i] != null)
            {
                coinsText[i].text = coins.ToString();
            }
        }
    }
}
