using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * VEX VASQUEZ
 * Last Updated: 12/3/2024
 * Keeps Track of Jenny's Dialogue 
 */


public class Jenny : MonoBehaviour
{
    public string Rom;
    public Dialogue Dialogue;

    //Triggers Dialogue for Jenny

    public void Speak()
    {
        DialogueManager.Instance.StartDialogue(Rom, Dialogue.RootNode);
    }


}
