using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstRouletteController : MonoBehaviour
{//회전속도
    float rotSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 클릭하면 회전 속도를 설정
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }
        //회전 속도만큼 룰렛을 회전
        transform.Rotate(0, 0, this.rotSpeed);

        if (Input.GetMouseButtonDown(1))
        {
            if(this.rotSpeed > 0)
            {
                this.rotSpeed -= 1;

            }
        }

    }
}
