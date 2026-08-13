using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class audioPanel : MonoBehaviour
{
    public GameObject gameObjects;
    public RectTransform buttonRect;
    public Button[] buttons;
    public AudioSource audioSource;
    public Slider progressSlider;
    public TMP_Text percentText;
    void Start()
    {
        gameObjects.SetActive(false);
        if (progressSlider != null)
        {

            progressSlider.interactable = false;
            progressSlider.minValue = 0f;
            progressSlider.maxValue = 1f;
        }
    }

    void Update()
    {
        float sliderProgress = audioSource.time / audioSource.clip.length;
        if (progressSlider != null)
        {
            progressSlider.value = sliderProgress;
        }
        if (percentText != null)
        {
            int percent = Mathf.FloorToInt(sliderProgress * 100f);
            percentText.text = percent + "%";
        }

    }
    public void audioTrue()
    {
        Vector3 buttonPosition = buttonRect.localScale;
        buttonPosition.y *= -1f;
        buttonRect.localScale = buttonPosition;
        if (gameObjects.activeSelf == false)
        {
            gameObjects.SetActive(true);
            

        }
        else if (gameObjects.activeSelf != false) { 
            gameObjects.SetActive(false);
        }
    }

    public void buttonAudioPlay()
    {
        ShowAll(buttons[1]);
        audioSource.Play();
    }
    public void buttonAudioPause()
    {
        ShowAll(buttons[0]);
        audioSource.Pause();
    }
    public void ShowAll(Button button) {
        HideAll();
        button.gameObject.SetActive(true);
    }

    public void HideAll()
    {
        for(int i =0; i<buttons.Length; i++)
        {
            buttons[i].gameObject.SetActive(false);
        }
    }
    

}
