using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstRouletteController : MonoBehaviour
{//ȸ���ӵ�
    float rotSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Ŭ���ϸ� ȸ�� �ӵ��� ����
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }
        //ȸ�� �ӵ���ŭ �귿�� ȸ��
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
