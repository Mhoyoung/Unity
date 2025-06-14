using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsoniPrefab;
    float power = 0f;
    float startVal = 0f;
    public float throwForce;


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startVal = Input.mousePosition.y;
        }

        if(Input.GetMouseButtonUp(0))
        {
            power = Input.mousePosition.y - startVal;

            GameObject bamsongi = Instantiate(bamsoniPrefab, transform.position, transform.rotation);

            //bamsongi.transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z + 1);
            bamsongi.transform.position = transform.position + transform.forward;

            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Vector3 worldDir = ray.direction;


            //bamsongi.GetComponent<BamsongiController>().Shoot(new Vector3(0, 500, 2000));
            //bamsongi.GetComponent<BamsongiController>().Shoot(worldDir * 2000);
            bamsongi.GetComponent<BamsongiController>().Shoot((transform.forward + transform.up * 0.5f).normalized * power * throwForce);
        }
        
    }
}
