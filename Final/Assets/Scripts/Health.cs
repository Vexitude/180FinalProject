using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;


/*
 * VEX VASQUEZ
 * Last Updated:12/11/2024
 * Health system UI for Player
 */
public class Health : MonoBehaviour
{
    public TextMeshProUGUI healthPoints;



    private int maxlives = 10;
    private int currentlives = 5;

    private void Start()
    {

    }

    private void Update()
    {
        healthPoints.text = "Lives: " + currentlives;
    }

    public void AddingHealth()
    {

        if (currentlives < maxlives)
        {
            currentlives++;
            healthPoints.text = "Lives: " + currentlives;
        }
    }

    public void LosingHealth()
    {
        if (currentlives >= 2)
        {
            currentlives--;
            healthPoints.text = "Lives: " + currentlives;
        }
        else
        {
            Debug.Log("Game Over");
            Restart();
        }
    }

  

    public void Restart()
    {
        Scene thisScene = SceneManager.GetActiveScene();
        string currentScene = thisScene.name;

        if (currentScene == "Level 1")
        {
            SceneManager.LoadScene(10);
        }
        if (currentScene == "Level 2")
        {
            SceneManager.LoadScene(13);
        }
        if (currentScene == "Level 3")
        {
            SceneManager.LoadScene(14);
        }
    }
}
