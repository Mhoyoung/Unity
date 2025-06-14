using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public float dropSpeed = -0.03f;
    void Update()
    {
        transform.Translate(0, dropSpeed, 0);

        if (transform.position.y < -2f)
        {
            transform.position = new Vector3(transform.position.x, 4, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Enter.");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter.");
    }
}
