using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondRouletteController : MonoBehaviour
{
    //ȸ���ӵ�
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
            // Ŭ���ϸ� ȸ�� �ӵ��� ����
            this.rotSpeed = 10;

            //ȸ�� �ӵ���ŭ �귿�� ȸ��
            transform.Rotate(0, 0, this.rotSpeed);
        }
        else if(Input.GetMouseButton(0) == false) 
        {
            //�귿�� ����
            this.rotSpeed *= 0.96f;

            //ȸ�� �ӵ���ŭ �귿�� ȸ��
            transform.Rotate(0, 0, this.rotSpeed);
        }
        
    }
}
