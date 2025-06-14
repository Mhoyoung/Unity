using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorTarget : MonoBehaviour
{
    public GameObject targetPrefab;

    Transform[] destinations;
    public float minDistance = 10;
    Transform player;
    void Start()
    {
        destinations = GetComponentsInChildren<Transform>(); //자기자신의 Transform도 포함
        player = GameObject.Find("Player").GetComponent<Transform>();
    }
    
    public void GenerateTargetObject()
    {
        int index;
        Vector3 position;

        do
        {
            index = Random.Range(1, destinations.Length);
            position = destinations[index].position;
        } while (Vector3.Distance(position, player.position) < minDistance);

        index = Random.Range(1, destinations.Length);

        GameObject target = Instantiate(targetPrefab, destinations[index].transform.position, Quaternion.identity);

        target.transform.SetParent(destinations[index]);
    }
}
