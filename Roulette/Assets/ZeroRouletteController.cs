using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroRouletteController : MonoBehaviour
{
    //ȸ���ӵ�
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
        // Ŭ���ϸ� ȸ�� �ӵ��� ����
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
            flag = true;
            
        }
        //ȸ�� �ӵ���ŭ �귿�� ȸ��
        transform.Rotate(0, 0, this.rotSpeed);

        //�귿�� ����
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
                Debug.Log("��� ����");
                flag = false;
            }
            else if (result >= 30 && result < 90)
            {
                Debug.Log("��� ����");
                flag = false;
            }
            else if (result >= 90 && result < 150)
            {
                Debug.Log("��� �ſ� ����");
                flag = false;
            }
            else if (result >= 150 && result < 210)
            {
                Debug.Log("��� ����");
                flag = false;
            }
            else if (result >= 210 && result < 270)
            {
                Debug.Log("��� ����");
                flag = false;
            }
            else if (result >= 270 && result < 330)
            {
                Debug.Log("��� ����");
                flag = false;
            }
    }
}
