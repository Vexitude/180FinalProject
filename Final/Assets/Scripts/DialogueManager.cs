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

    private void Awake()
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

        DialogueTitleText.text = title;
        DialogueBodyText.text = node.dialogueText;

        foreach(Transform child in responseButtonContainer)
        {
            Destroy(child.gameObject);
        }

        foreach (DialogueResponse response in node.responses)
        {
            GameObject buttonObj = Instantiate(responseButtonPrefab, responseButtonContainer);
            buttonObj.GetComponentInChildren<TextMeshProUGUI>().text = response.responseText;

            buttonObj.GetComponent<Button>().onClick.AddListener(() => SelectResponse(response, title));
        }

    }

    public void SelectResponse(DialogueResponse response, string title)
    {
        if (!response.nextNode.IsLastNode())
        {
            StartDialogue(title, response.nextNode);
        }
        else
        {
            HideDialogue();
        }
    }

    public void HideDialogue()
    {
        DialogueBox.SetActive(false);

    }

    private void ShowDialogue()
    {
        DialogueBox.SetActive(true);

    }
}
