using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/*
 * Name: Alan Buell
 * Date: 12/10/024
 * Des: Calls ending
 */

public class Ending : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<PlayerMovement>())
        {
            SceneManager.LoadScene(9);
        }
    }
}
