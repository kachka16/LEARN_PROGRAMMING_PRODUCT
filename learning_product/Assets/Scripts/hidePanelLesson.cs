using UnityEngine;

public class hidePanelLesson : MonoBehaviour
{
    public GameObject[] gameObjectsL;
    private void Start()
    {
        ShowMenu(gameObjectsL[0]);
    }
    void HideAll()
    {
        for (int i = 0; i < gameObjectsL.Length; i++)
        {
            gameObjectsL[i].SetActive(false);
        }
    }
    void ShowMenu(GameObject menu)
    {
        HideAll();
        menu.SetActive(true);
    }
    public void MainMenuOpen()
    {
        ShowMenu(gameObjectsL[0]);
    }
    public void ResultMenu()
    {
        ShowMenu(gameObjectsL[1]);
    }
}
