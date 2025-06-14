using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    Transform playerTR;
    GeneratorTarget gt;

    void Start()
    {
        playerTR = GameObject.Find("Player").transform;
        gt = GameObject.FindAnyObjectByType<GeneratorTarget>();
    }

    void Update()
    {
        transform.LookAt(playerTR);
    }

    private void OnTriggerEnter(Collider collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
        gt.GenerateTargetObject();
    }
}
