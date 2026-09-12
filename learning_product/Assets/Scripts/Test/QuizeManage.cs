using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class QuizeManage : MonoBehaviour
{
    public List<QuestionAndAnswer> QnA;

    public GameObject[] gb; 
    public GameObject GoPanel;
    public GameObject qQuize;
    public GameObject starTest;
    public int currentQuestion;
    public TextMeshProUGUI ScoreText;
    int totalQuestions= 0;


    [SerializeField] private hidePanelLesson hidepanel;
    [SerializeField] private TaskEnd taskend;
    public TextMeshProUGUI QuestionTxt;
    public int score;
    public TextMeshProUGUI QuestionCounterTxt;
    public Animator resultAnimator;
    public Animator resultAnimator2;


    private void Start()
    {
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        qQuize.SetActive(false);
        starTest.SetActive(true);
        generateQuestion();
    }

    public void startTestMethid()
    {
        starTest.SetActive(false);
        qQuize.SetActive(true);
        resultAnimator2.Play("animQuestions");
    }
    void GameOver()
    {
        qQuize.SetActive(false);
        GoPanel.SetActive(true);
        resultAnimator.Play("animresulltTest1");
        ScoreText.text = score + "/" + totalQuestions;
        if(score == totalQuestions)
        {
            taskend.FinishTask();
            taskend.CompleseTast();
            hidepanel.ResultMenu();
        }
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();

    }
    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
            generateQuestion();
    }
    void SetAnswer()
    {
        for(int i = 0; i < gb.Length; i++)
        {
            gb[i].GetComponent<Image>().color = Color.white;
            gb[i].transform.GetComponent<AnswerManage>().isCorrect = false;
            gb[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestion].Answers[i];
            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                gb[i].transform.GetComponent<AnswerManage>().isCorrect = true;
            }
        }

    }
    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQuestion].Questions;
            SetAnswer();
            if(QuestionCounterTxt != null)
            {
                int currentNumberQ = totalQuestions - QnA.Count + 1;
                QuestionCounterTxt.text  = currentNumberQ +"/" + totalQuestions;
            }
        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }
    }
}
