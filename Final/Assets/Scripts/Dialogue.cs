using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;


/*
 * Name: Alan Buell
 * Date: 12/11/2024
 * Des: Allows for Jenny to Speak, UI
 */

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject Buttons;
    


    private int index;
    public QuizManager Quiz;


    void Start()
    {
        

        title.text = "Jenny";
        textComponent.text = string.Empty;
        StartDialogue();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                //textComponent.setActive(false);
                textComponent.text = lines[index];
                
            }
        }
    }

    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }


    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
        
    }

    public void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());

        }
        else
        {
            textComponent.gameObject.SetActive(false);
            Buttons.SetActive(true);
            Quiz.GenerateQuestion();
        }

    }
}
