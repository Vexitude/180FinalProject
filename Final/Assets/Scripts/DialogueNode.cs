using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * VEX VASQUEZ
 * Last Updated:12/3/2024
 * Manages Dialogue Text and Responses Inputs
 */

[System.Serializable]
public class DialogueNode : MonoBehaviour
{
    public string dialogueText;
    public List<DialogueResponse> responses;
}
