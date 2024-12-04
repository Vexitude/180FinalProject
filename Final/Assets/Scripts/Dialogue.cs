using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting.FullSerializer;

/*
 * VEX VASQUEZ
 * 11/21/2024
 * Manages Dialogue between characters
 */

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue/Dialogue Asset")]

public class Dialogue : ScriptableObject
{
    public DialogueNode RootNode;

}