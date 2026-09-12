using System.Collections;
using System.Transactions;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class AnimLevelLoading : MonoBehaviour
{
    public float transitionTime = 1f;

    [Header("Animators")]
    public Animator circleAnimator;
    public Animator kvadratAnimator;

    public static AnimLevelLoading instance;


    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "MenuScene")
        {
            circleAnimator.ResetTrigger("end");
            circleAnimator.SetTrigger("start");
        }
    }

    public void LoadLessonCircle()
    {
        StartCoroutine(LoadScene(circleAnimator,"Lesson"));
    }

    public void LoadMenuCircle()
    {
        StartCoroutine(LoadScene(circleAnimator,"MenuScene"));
    }
    public void LoadLessonKvadrat()
    {
        StartCoroutine(LoadScene(kvadratAnimator, "Lesson"));
    }

    public void LoadMenuKvadrat()
    {
        StartCoroutine(LoadScene(kvadratAnimator, "MenuScene"));
    }
    IEnumerator LoadScene(Animator anim, string sceneName)
    {
        anim.SetTrigger("end");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneName);
    }

}
