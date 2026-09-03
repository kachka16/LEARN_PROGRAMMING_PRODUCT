using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Transactions;
using Unity.VectorGraphics;
using UnityEngine.InputSystem;
using static System.TimeZoneInfo;

public class LevelSelection : MonoBehaviour
{
    public Button[] lvlButtons; 
    public float transitionTime = 1f;
    public Animator circleAnimator;
    public GameObject[] locks;
    


    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 1);

        locks[0].SetActive(false);
        for (int i =0; i< lvlButtons.Length; i++)
        {
            bool unlocked = i + 1 <= levelAt;
            lvlButtons[i].interactable = unlocked;

            if (i < locks.Length && locks[i] != null)
            {
                locks[i].SetActive(!unlocked);
            }
        }
    }

    public void OpenTask(int index)
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 1);
        if (index> levelAt)
        {
            return;
        }
        PlayerPrefs.SetInt("SelectedTask", index); 
        PlayerPrefs.Save();
        StartCoroutine(LoadScene(circleAnimator, "Lesson"));
    }

    public void ResetGame()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();

        SceneManager.LoadScene(1);
    }

    IEnumerator LoadScene(Animator anim, string sceneName)
    {
        anim.SetTrigger("end");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneName);
    }
}
