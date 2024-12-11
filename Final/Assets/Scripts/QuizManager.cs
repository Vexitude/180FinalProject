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
    public GameObject jennyUpset;


    public TextMeshProUGUI QuestionTxt;

    private int finalDate = 5;
    private int secondDate = 4;
    private int finalHall = 6;

    private void Start()
    {
        

    }

    private void Update()
    {

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
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Level 2")
        {
            SceneManager.LoadScene(finalDate);
        }
        if (sceneName == "Level 1")
        {
            SceneManager.LoadScene(secondDate);
        }
        if (sceneName == "Level 3")
        {
            SceneManager.LoadScene(finalHall);
        }

    }
}
