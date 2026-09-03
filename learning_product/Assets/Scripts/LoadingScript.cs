using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScript : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] Slider loadingSlider;
    [SerializeField] float loadSpeed = 0.5f;
    [SerializeField] string menuSceneName = "MenuScene";
    [SerializeField] private Animator transitionAnimator;
    [SerializeField] private string endTriggerName = "end";
    [SerializeField] private float transitionDuration = 1f;
    [SerializeField] public float waitAfterLoad = 5f;
    private void Start()
    {
        Application.targetFrameRate = 60;
        loadingSlider.value = 0f;
        StartCoroutine(FakeLoading());
    }
    IEnumerator FakeLoading()
    {
        while (loadingSlider.value < 1f)
        {
            loadingSlider.value += loadSpeed * Time.deltaTime;
            yield return null;
        }


        loadingSlider.value = 1f;
        yield return new WaitForSeconds(waitAfterLoad);

        if (transitionAnimator != null)
        {
            transitionAnimator.SetTrigger(endTriggerName);
        }

        yield return new WaitForSeconds(transitionDuration);
        SceneManager.LoadScene(menuSceneName);
    }
}
