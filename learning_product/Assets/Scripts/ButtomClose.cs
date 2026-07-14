using UnityEngine;

public class ButtomClose : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject shopMenu;
    public GameObject taskMenu;
    public GameObject taskPurpleExercise;
    public GameObject taskPinkExercise;

    private void Start()
    {
        mainMenu.SetActive(true);
        shopMenu.SetActive(false);
        taskMenu.SetActive(false);
        taskPurpleExercise.SetActive(false);
        taskPinkExercise.SetActive(false);

    }
    public void ShopMenuOpen()
    {
        shopMenu.SetActive(true);
        mainMenu.SetActive(false);
        taskMenu.SetActive(false);
        taskPurpleExercise.SetActive(false);
        taskPinkExercise.SetActive(false);

    }
    public void TaskMenuOpen()
    {
        shopMenu.SetActive(false);
        mainMenu.SetActive(false);
        taskMenu.SetActive(true);
        taskPurpleExercise.SetActive(false);
        taskPinkExercise.SetActive(false);

    }
    public void PurpleExerciseOpen()
    {
        shopMenu.SetActive(false);
        mainMenu.SetActive(false);
        taskMenu.SetActive(false);
        taskPurpleExercise.SetActive(true);
        taskPinkExercise.SetActive(false);

    }
    public void PinkExerciseOpen()
    {
        shopMenu.SetActive(false);
        mainMenu.SetActive(false);
        taskMenu.SetActive(false);
        taskPurpleExercise.SetActive(false);
        taskPinkExercise.SetActive(true);

    }
    public void ButtonBack()
    {
        mainMenu.SetActive(true);
        shopMenu.SetActive(false);
        taskMenu.SetActive(false);
        taskPurpleExercise.SetActive(false);
        taskPinkExercise.SetActive(false);

    }
}
