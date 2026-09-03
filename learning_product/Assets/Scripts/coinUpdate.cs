using TMPro;
using UnityEngine;

public class coinUpdate : MonoBehaviour
{
    private void Start()
    {
        CoinManadger.instance.UpdateCoinsText();
        heartManager.instance.UpdateHeartText();
        keyManager.instance.UpdateKeyText();
    }
}
