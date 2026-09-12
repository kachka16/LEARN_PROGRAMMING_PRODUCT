using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AnswerManage : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizeManage qManager;
    public void Answer()
    {
        Image buttomImage = GetComponent<Image>();
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            StartCoroutine(NextQues());
            GetComponent<Image>().color = new Color32(50, 255, 65, 255);
        }
        else
        {
            Debug.Log("Wrong Answer");
            StartCoroutine(NextQues());
            GetComponent<Image>().color = new Color32(255, 111, 69, 255);
        }
    }

    IEnumerator NextQues()
    {
        yield return new WaitForSeconds(0.2f);
        if (isCorrect)
        {
            qManager.correct();
        }
        else
        {
            qManager.wrong();
        }
    }
}
