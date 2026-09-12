using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskEnd : MonoBehaviour
{
    public GameObject[] task;
    private int currentTask;
    private bool completed;
    private int keyScore = 1;
    private int coinScore = 30;
    private int starScore = 1000;

    public TextMeshProUGUI keyText;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI starText;
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
            keyText.text = "0";
            starText.text = "0";
            coinText.text = "0";
            return;
        }

        int coins = PlayerPrefs.GetInt("Coins", 0);
        coins += coinScore;

        int hearts = PlayerPrefs.GetInt("Hearts", 0);
        hearts += starScore;

        int keys = PlayerPrefs.GetInt("Keys", 0);
        keys += keyScore;

        keyText.text = keyScore.ToString();
        starText.text = starScore.ToString();
        coinText.text = coinScore.ToString();

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
