using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
 //   [SerializeField] float xValue = 0.00f;
    float yValue = 0.00f;
    float moveSpeed = 2f;
 //   [SerializeField] float zValue = 0.00f;
    void Start()
    {
    }

    void Update()
    {
        // TODO: add keyboard controls 
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical")* moveSpeed * Time.deltaTime;
        transform.Translate(xValue, yValue, zValue);

    }
}
