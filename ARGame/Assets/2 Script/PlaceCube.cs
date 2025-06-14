using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCube : MonoBehaviour
{
    public GameObject cubePrefab;
    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        int tabCount = Input.touchCount;
        if (tabCount < 1) return;

        Touch touch = Input.GetTouch(0); //여러 개의 터치가 들어와도 첫번째 터치만
        Vector3 touchPosition = cam.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 1.0f));

        if(touch.phase == TouchPhase.Began) //터치하는 순간에만
        {
            GameObject go = Instantiate(cubePrefab, touchPosition, transform.rotation);
            go.transform.parent = transform;
        }
    }
}
