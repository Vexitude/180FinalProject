using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * VEX VASQUEZ
 * Last Updated:12/3/2024
 * Manages Dialogue Text and Responses 
 */

[System.Serializable]
public class DialogueResponse : MonoBehaviour
{
    public string responseText;
    public DialogueNode nextNode;
}
