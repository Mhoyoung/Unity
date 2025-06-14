using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTF : MonoBehaviour
{
    private float moveSpeed = 20f;
    private float rotationSpeed = 50f;

    

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float move = zInput * moveSpeed * Time.deltaTime;
        float rotate = xInput * rotationSpeed * Time.deltaTime;
        transform.Translate(0, 0, move);
        transform.Rotate(0, rotate, 0);
    }
}
