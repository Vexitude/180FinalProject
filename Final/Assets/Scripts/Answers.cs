using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    public Health lives;

    public void Answer()
    {
        if(isCorrect)
        {
            Debug.Log("Good Choice!");
            quizManager.Correct();
            lives.AddingHealth();
            quizManager.jennyUpset.SetActive(false);
        }
        else
        {
            Debug.Log("Maybe Not...");
            quizManager.Correct();
            lives.LosingHealth();
            quizManager.jennyUpset.SetActive(true);
        }
    }
}
