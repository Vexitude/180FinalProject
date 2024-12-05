using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/*
 * VEX VASQUEZ
 * Last Updated:12/3/2024
 * Manages Dialogue Text and Responses Inputs
 */

[System.Serializable]
public class DialogueNode
{
    public string dialogueText;
    public List<DialogueResponse> responses;

    internal bool IsLastNode()
    {
        return responses.Count <= 0;
    }
}
