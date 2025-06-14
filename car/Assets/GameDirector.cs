using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // TextMeshPro를 사용하기 데 필요하다.

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    void Start()
    {
        this.car = GameObject.Find("car_0");
        this.flag = GameObject.Find("flag_0");
        this.distance = GameObject.Find("distance");
    }

    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if (length >= 0)
        {
            this.distance.GetComponent<TextMeshProUGUI>().text = "Distance:" + length.ToString("F2") + "m";
        }
        else
        {
            this.distance.GetComponent<TextMeshProUGUI>().text = "GameOver";
        }
    }
}