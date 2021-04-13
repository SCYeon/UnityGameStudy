using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlagController : MonoBehaviour
{
    bool mouseFlag = false;
    float rotSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            if(mouseFlag == true)
            {
                mouseFlag = false;
            }
            else
            {
                mouseFlag = true;
            }
        }

        if (mouseFlag == false) {
            this.rotSpeed = 10;
        }
        if (mouseFlag == true) {
            this.rotSpeed = 0;
        }

        transform.Rotate(0, this.rotSpeed, 0);
    }
}
