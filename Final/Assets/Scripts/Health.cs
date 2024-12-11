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
    private int currentlives = 5;
    public int button;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void AddingHealth()
    {

        if (currentlives < maxlives)
        {
            currentlives++;
        }
    }

    public void LosingHealth()
    {
        if (currentlives >= 1)
        {
            currentlives--;
        }
        else
        {
            Debug.Log("Game Over");
            Restart();
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

        healthPoints.text = "Lives: " + currentlives;
    }

    public void Restart()
    {
        Scene thisScene = SceneManager.GetActiveScene();
        string currentScene = thisScene.name;

        if (currentScene == "Level 1")
        {
            SceneManager.LoadScene(0);
        }
        if (currentScene == "Level 2")
        {
            SceneManager.LoadScene(4);
        }
        if (currentScene == "Level 3")
        {
            SceneManager.LoadScene(5);
        }
    }
}
