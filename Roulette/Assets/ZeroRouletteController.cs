using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroRouletteController : MonoBehaviour
{
    //회전속도
    float rotSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    bool flag = false;
    float result = 0;

    // Update is called once per frame
    void Update()
    {
        // 클릭하면 회전 속도를 설정
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
            flag = true;
            
        }
        //회전 속도만큼 룰렛을 회전
        transform.Rotate(0, 0, this.rotSpeed);

        //룰렛을 감속
        this.rotSpeed *= 0.96f;

        
        if (flag == true && this.rotSpeed <= 0.03)
        {
            result = transform.rotation.eulerAngles.z;
            Result();
        }

    }
    void Result()
    {
            if ((result >= 330 && result < 360) || (result >= 0 && result < 30))
            {
                Debug.Log("운수 나쁨");
                flag = false;
            }
            else if (result >= 30 && result < 90)
            {
                Debug.Log("운수 대통");
                flag = false;
            }
            else if (result >= 90 && result < 150)
            {
                Debug.Log("운수 매우 나쁨");
                flag = false;
            }
            else if (result >= 150 && result < 210)
            {
                Debug.Log("운수 보통");
                flag = false;
            }
            else if (result >= 210 && result < 270)
            {
                Debug.Log("운수 조심");
                flag = false;
            }
            else if (result >= 270 && result < 330)
            {
                Debug.Log("운수 좋음");
                flag = false;
            }
    }
}
