using UnityEngine;

public class ButtomClose : MonoBehaviour
{
    public GameObject[] gameObjects;
    public int panelIndex =0;

    private void Start()
    {
        ShowMenu(panelIndex);
    }

    public void HideAll()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].SetActive(false);
        }
    }


    public void ShowMenu(int index)
    {
        HideAll();
        gameObjects[index].SetActive(true);
    }
}
