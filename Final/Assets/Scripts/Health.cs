using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public string correct;

    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Level 2")
        {
            print("Test");

            if(gameObject.GetComponent<DialogueManager>())
            {
                if(gameObject.GetComponentInParent<Text>())
                {
                    print("Finishing this later");
                }
            }
        }
    }
}
