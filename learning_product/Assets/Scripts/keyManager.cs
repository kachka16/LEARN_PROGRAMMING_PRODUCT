using TMPro;
using UnityEngine;

public class keyManager : MonoBehaviour
{
    public TextMeshProUGUI[] keyText;
    public static keyManager instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateKeyText();
    }

    public void UpdateKeyText()
    {
        int coins = PlayerPrefs.GetInt("Keys", 0);

        for (int i = 0; i < keyText.Length; i++)
        {
            if (keyText[i] != null)
            {
                keyText[i].text = coins.ToString();
            }
        }
    }
}
