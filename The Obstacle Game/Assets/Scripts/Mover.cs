using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    Rigidbody rigidBody;
    float xInput;
    float zInput;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        PrintInstruction();
    }

    void Update()
    {
        PlayerInput();
    }

    private void MovePlayer()
    {
        Vector3 velocity = new Vector3(xInput, 0f, zInput) * moveSpeed * Time.deltaTime;
        rigidBody.velocity = velocity;
    }

    private void PlayerInput()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player using WASD or arrow keys");
        Debug.Log("Don't hit the walls");
    }

}
