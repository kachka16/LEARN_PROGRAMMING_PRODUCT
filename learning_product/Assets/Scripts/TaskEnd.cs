using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskEnd : MonoBehaviour
{
    public GameObject[] task;
    private int currentTask;
    private bool completed;
    void Start()
    {
        currentTask = PlayerPrefs.GetInt("SelectedTask", 1);
        completed = PlayerPrefs.GetInt("Task" + currentTask, 0) == 1;
        for (int i =0; i<task.Length; i++)
        {
            task[i].SetActive(i == currentTask - 1);
        }
    }
    public void FinishTask()
    {
        currentTask = PlayerPrefs.GetInt("SelectedTask", 1);
        if (PlayerPrefs.GetInt("Task" + currentTask, 0) == 1)
        {
            return;
        }

        int coins = PlayerPrefs.GetInt("Coins", 0);
        coins += 30;

        int hearts = PlayerPrefs.GetInt("Hearts", 0);
        hearts += 1;

        int keys = PlayerPrefs.GetInt("Keys", 0);
        keys += 1;

        PlayerPrefs.SetInt("Coins", coins);
        PlayerPrefs.SetInt("Hearts", hearts);
        PlayerPrefs.SetInt("Keys", keys);
        PlayerPrefs.SetInt("Task" + currentTask, 1);
        PlayerPrefs.Save();
    }
    public void CompleseTast()
    {
        int nextLevel = currentTask + 1;
        PlayerPrefs.SetInt("levelAt", nextLevel);
        PlayerPrefs.Save();
    }
}
