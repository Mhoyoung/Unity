using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawSpheres : MonoBehaviour
{
    public GameObject spherePrefab;
    public Camera cam;


    GameManager gm;
    float minDistance = 0.2f;
    Vector3 prevPosition = new Vector3(0, 0, 0);

    void Start()
    {
        gm = Object.FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (gm.isDrawing == false) return;

        Vector3 currentPosition = cam.ScreenToWorldPoint(new Vector3(Screen.width/2, Screen.height/2, 0.5f));

        float distance = Vector3.Distance(currentPosition, prevPosition);

        if (distance < minDistance) return;

        GameObject go = Instantiate(spherePrefab, currentPosition, transform.rotation);
        go.transform.parent = transform;
        prevPosition = currentPosition;
    }
}
