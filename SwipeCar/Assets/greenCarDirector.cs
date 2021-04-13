using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class greenCarDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;
    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("greencar");
        this.flag = GameObject.Find("greenflag");
        this.distance = GameObject.Find("greenCarDist");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.car.transform.position.y - this.flag.transform.position.y;
        this.distance.GetComponent<Text>().text = "GreenCar 목표 지점까지" + length.ToString("F2") + "m";
    }
}
