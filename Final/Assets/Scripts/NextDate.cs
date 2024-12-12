using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * VEX VASQUEZ
 * Last Updated:12/5/2024
 * For Door Detections
 */

public class NextDate : MonoBehaviour
{

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<PlayerMovement>())
        {
            print("Entered Door");
        }
    }
}
