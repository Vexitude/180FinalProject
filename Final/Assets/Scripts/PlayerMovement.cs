using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Name: Alan Buell
 * Date: 11/21/2024
 * Des: Handles player movement moving with the A, D, left arrow and right arrow keys.
 * also handles collsion/trigger enters for walls (invisible), doors, and the dateable character at the end. 
 */

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10;

    private Vector3 moveDir;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            moveDir = Vector3.left;
            rb.MovePosition(transform.position + moveDir * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            moveDir = Vector3.right;
            rb.MovePosition(transform.position + moveDir * moveSpeed * Time.deltaTime);
        }
   
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<NextDate>())
        {
            if (collision.gameObject.tag == "Door1")
            {
                SceneManager.LoadScene(2);
            }

            if (collision.gameObject.tag == "Door2")
            {
                SceneManager.LoadScene(3);
            }
            if (collision.gameObject.tag == "Door3")
            {
                SceneManager.LoadScene(4);
            }

        }
    }

}
