using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
 //   [SerializeField] float xValue = 0.00f;
    float yValue = 0.00f;
    float moveSpeed = 10f;
 //   [SerializeField] float zValue = 0.00f;
    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();        
    }

    void PrintInstructions () 
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Please help ben square head get to the end");
    }

    void MovePlayer() 
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(xValue, yValue, zValue);

    }
}
