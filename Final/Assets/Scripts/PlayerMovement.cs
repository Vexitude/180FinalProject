using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (Input.GetKey(KeyCode.A))
        {
            moveDir = Vector3.left;
            rb.MovePosition(transform.position + moveDir * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDir = Vector3.right;
            rb.MovePosition(transform.position + moveDir * moveSpeed * Time.deltaTime);
        }

            
    }
}
