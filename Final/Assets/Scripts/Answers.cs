using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
    public QuizManager quiz;
    public bool isCorrect = false;

    public void Answer()
    {
        if(isCorrect)
        {
            quiz.Correct();
            quiz.jennyUpset.SetActive(false);
            //gameObject.GetComponent<QuizManager>().Correct();
            //gameObject.GetComponent<QuizManager>().jennyUpset.SetActive(false);
            Debug.Log("Good Choice!");
        }

        else
        {
            quiz.Wrong();
            quiz.jennyUpset.SetActive(true);
            //gameObject.GetComponent<QuizManager>().Wrong();
            //gameObject.GetComponent<QuizManager>().jennyUpset.SetActive(true);
            Debug.Log("Maybe Not...");
        }
    }
}
