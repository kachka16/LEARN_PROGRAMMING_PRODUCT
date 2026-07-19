using System.Collections;
using System.Transactions;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class AnimLevelLoading : MonoBehaviour
{
    public float transitionTime = 1f;
    public Animator circleAnimator;
    public static AnimLevelLoading instance;


    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "MenuScene")
        {
            circleAnimator.SetTrigger("start");
        }
    }

    public void LoadLesson()
    {
        StartCoroutine(LoadScene("Lesson"));
    }

    public void LoadMenu()
    {
        StartCoroutine(LoadScene("MenuScene"));
    }

    IEnumerator LoadScene(string sceneName)
    {
        circleAnimator.SetTrigger("end");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneName);
    }
}
