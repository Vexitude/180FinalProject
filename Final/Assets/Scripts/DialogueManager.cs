using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Threading;

/*
 * VEX VASQUEZ
 * Last Updated:12/3/2024
 * Manages Dialogue and Responses
 */

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance { get; private set;  }

    //UI refs
    public GameObject DialogueBox;
    public TextMeshProUGUI DialogueTitleText, DialogueBodyText;
    public GameObject responseButtonPrefab;
    public Transform responseButtonContainer;

    private void On()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        //Initially hide the Dialogue UI

        HideDialogue();


    }

    public void StartDialogue(string title, DialogueNode node)
    {
        ShowDialogue();
    }
}
