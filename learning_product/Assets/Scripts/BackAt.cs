using UnityEngine;

public class BackAt : MonoBehaviour
{
    public void backMenu(int index)
    {
        PlayerPrefs.SetInt("levelAt", index);
    }
}
