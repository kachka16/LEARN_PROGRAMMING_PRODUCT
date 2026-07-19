using UnityEngine;

public class ButtomClose : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject shopMenu;
    public GameObject taskMenu;
    public GameObject accountMenu;
    public GameObject settingMenu;
    public GameObject taskPurpleExercise;
    public GameObject taskPinkExercise;
    public GameObject taskBlueExercise;
    public GameObject taskGreenExercise;

    private void Start()
    {
        ShowMenu(mainMenu);
    }

    void HideAll()
    {
        mainMenu.SetActive(false);
        shopMenu.SetActive(false);
        taskMenu.SetActive(false);
        accountMenu.SetActive(false);
        settingMenu.SetActive(false);
        taskPurpleExercise.SetActive(false);
        taskPinkExercise.SetActive(false);
        taskBlueExercise.SetActive(false);
        taskGreenExercise.SetActive(false);
    }


    void ShowMenu(GameObject menu)
    {
        HideAll();
        menu.SetActive(true);
    }
    public void MainMenuOpen()
    {
        ShowMenu(mainMenu);
    }
    public void ShopMenuOpen()
    {
        ShowMenu(shopMenu);
    }
    public void TaskMenuOpen()
    {
        ShowMenu(taskMenu);
    }
    public void AccountMenuOpen()
    {
        ShowMenu(accountMenu);
    }
    public void SettingMenuOpen()
    {
        ShowMenu(settingMenu);
    }
    public void PurpleExerciseOpen()
    {
        ShowMenu(taskPurpleExercise);
    }
    public void PinkExerciseOpen()
    {
        ShowMenu(taskPinkExercise);
    }
    public void BlueExerciseOpen()
    {
        ShowMenu(taskBlueExercise);
    }
    public void GreenExerciseOpen()
    {
        ShowMenu(taskGreenExercise);
    }
}
