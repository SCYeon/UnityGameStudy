using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondRouletteController : MonoBehaviour
{
    //회전속도
    float rotSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {

    }
    
            
    // Update is called once per frame
    void Update()
    {        
        if (Input.GetMouseButton(0) == true)
        {
            // 클릭하면 회전 속도를 설정
            this.rotSpeed = 10;

            //회전 속도만큼 룰렛을 회전
            transform.Rotate(0, 0, this.rotSpeed);
        }
        else if(Input.GetMouseButton(0) == false) 
        {
            //룰렛을 감속
            this.rotSpeed *= 0.96f;

            //회전 속도만큼 룰렛을 회전
            transform.Rotate(0, 0, this.rotSpeed);
        }
        
    }
}
