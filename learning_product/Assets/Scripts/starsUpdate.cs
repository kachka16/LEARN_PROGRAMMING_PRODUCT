using UnityEngine;
using UnityEngine.UI;

public class starsUpdate : MonoBehaviour
{
    public Image[] stars;
    public int taskfirstID;

    void start()
    {
        for(int i = 0; i <stars.Length; i++)
        {
            int taskID = taskfirstID + i + 1;
            bool completed = PlayerPrefs.GetInt("Task" + taskID, 0) == 1;

            if (completed)
            {
                stars[i].color = new Color(1f, 1f, 1f, 1f);
            }
            else
            {
                stars[i].color = new Color(1f, 1f, 1f, 0.3f);
            }
        }
    }
}
