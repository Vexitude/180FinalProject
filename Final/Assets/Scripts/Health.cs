using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Level 2")
        {
            print("Test");

            if(gameObject.GetComponent<DialogueManager>())
            {
                //gameObject
            }
        }
    }
}
