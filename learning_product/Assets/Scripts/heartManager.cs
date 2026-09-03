using TMPro;
using UnityEngine;

public class heartManager : MonoBehaviour
{
    public TextMeshProUGUI[] heartsText;
    public static heartManager instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateHeartText();
    }

    public void UpdateHeartText()
    {
        int coins = PlayerPrefs.GetInt("Hearts", 0);

        for (int i = 0; i < heartsText.Length; i++)
        {
            if (heartsText[i] != null)
            {
                heartsText[i].text = coins.ToString();
            }
        }
    }
}

