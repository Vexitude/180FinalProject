using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * VEX VASQUEZ
 * Last Updated:12/5/2024
 * Manages Scene Switching to Next Date
 */

public class NextDate : MonoBehaviour
{

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<PlayerMovement>())
        {
            //Destroy(gameObject);
        }
    }
}
