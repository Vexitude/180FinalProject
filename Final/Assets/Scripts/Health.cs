using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Health : MonoBehaviour
{

    public string correct;
    TMP_Text selection;

    private void Start()
    {

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        GameObject textobj;
        

        string clickedButtonName = EventSystem.current.currentSelectedGameObject.name;

       //mytext = textobj.GetComponent<TMP_Text>();

        textobj = this.gameObject.transform.GetChild(0).gameObject;
        Debug.Log(textobj.name);
        selection = textobj.GetComponent<TextMeshPro>();

        if (sceneName == "Level 2")
        {
            if(selection)
            {
                if(selection != null)
                {
                    print("test");
                }
         
            }

        }
    }

}
