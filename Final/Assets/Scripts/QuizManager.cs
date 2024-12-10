using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class QuizManager : MonoBehaviour
{
    public List<QA> QnA;
    public GameObject[] options;
    public int currentQuestion;


    public TextMeshProUGUI QuestionTxt;

    private void Start()
    {
        

    }

    private void Update()
    {
        /*
        if(gameObject.GetComponent<Dialogue>().activeSelf == false)
        {
            
        }
        */
    }

    public void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Answers>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<Answers>().isCorrect = true;
            }
        }

    }

    public void GenerateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Date Completed!");
            DateCompleted();
        }
    }

    public void Correct()
    {
        QnA.RemoveAt(currentQuestion);
        GenerateQuestion();
    }

    public void DateCompleted()
    {
        SceneManager.LoadScene(0);
    }
}
