using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

/*
 * VEX VASQUEZ
 * Last Updated: 12/4/2024
 * Keeps Track of Jenny's Dialogue 
 */


public class Jenny : MonoBehaviour
{
    public string Name;
    public Dialogue Dialogue;

    //Triggers Dialogue for Jenny

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Speak();
        }
    }


    public void Speak()
    {
        DialogueManager.Instance.StartDialogue(Name, Dialogue.RootNode);
    }


}
