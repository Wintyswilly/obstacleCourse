using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
 //   [SerializeField] float xValue = 0.00f;
    [SerializeField] float yValue = 0.00f;
 //   [SerializeField] float zValue = 0.00f;
    void Start()
    {
    }

    void Update()
    {
        // TODO: add keyboard controls 
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");
        transform.Translate(xValue, yValue, zValue);

    }
}
