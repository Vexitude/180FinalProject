using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Health : MonoBehaviour
{
    public TextMeshProUGUI healthPoints;
    public Answers replies;



    private int maxlives = 10;
    private int startinglives = 5;
    public int button;

    private void Start()
    {
        
    }

    private void Update()
    {

    }

    public void AddingHealth()
    {

        if (startinglives < maxlives)
        {
            startinglives++;
        }
    }

    public void LosingHealth()
    {
        if (startinglives >= 1)
        {
            startinglives--;
        }
        else
        {
            Debug.Log("Game Over");

        }
    }

    public void LifeHolder()
    {
        if (replies.isCorrect == false)
        {
            AddingHealth();
        }
        else
        {
            LosingHealth();
        }

        healthPoints.text = "Lives: " + startinglives;
    }
}
