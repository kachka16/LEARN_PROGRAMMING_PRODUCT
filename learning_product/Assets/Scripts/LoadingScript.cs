using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScript : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] Slider loadingSlider;
    [SerializeField] float loadSpeed = 0.6f;
    [SerializeField] string menuSceneName = "MenuScene";
    void Start()
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
        SceneManager.LoadScene(menuSceneName);
    }
}
