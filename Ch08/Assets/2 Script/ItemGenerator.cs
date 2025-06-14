using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;

    float bombRatio = 0.2f;
    float span = 1f;
    float speed = -0.03f;
    
    float delta = 0f;

    public void SetParameters(float span, float speed, float bombRatio)
    {
        this.span = span;
        this.speed = speed;
        this.bombRatio = bombRatio;
    }

    void Update()
    {
        delta += Time.deltaTime;

        if(delta > span)
        {
            GameObject item;
            float dice = Random.Range(0f, 1f);
            if(dice < bombRatio)
            {
                item = Instantiate(bombPrefab, transform.position, transform.rotation);

            }
            else
            {
                item = Instantiate(applePrefab, transform.position, transform.rotation);

            }

            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            item.transform.position = new Vector3(x, transform.position.y, z);
            item.GetComponent<ItemController>().dropSpeed = speed;

            delta = 0;
        }
    }
}
