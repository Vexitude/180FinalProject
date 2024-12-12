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
    public Health health;
    public Answers replies;

    public TextMeshProUGUI QuestionTxt;

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
            DateCompleted();
        }
    }

    public void Correct()
    {
        QnA.RemoveAt(currentQuestion);
        GenerateQuestion();
        health.AddingHealth();
    }

    public void Wrong()
    {
        QnA.RemoveAt(currentQuestion);
        GenerateQuestion();
        health.LosingHealth();
    }

    public void DateCompleted()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Level 2")
        {
            SceneManager.LoadScene(12);
        }
        if (sceneName == "Level 1")
        {
            SceneManager.LoadScene(11);
        }
        if (sceneName == "Level 3")
        {
            SceneManager.LoadScene(6);
        }

    }
}
