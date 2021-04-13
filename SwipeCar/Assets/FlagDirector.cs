using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlagDirector : MonoBehaviour
{
    int num;
    float count = 0;
    GameObject flag;
    GameObject flagturn;
    // Start is called before the first frame update
    void Start()
    {
        this.flag = GameObject.Find("flag");
        this.flagturn = GameObject.Find("flagTurn");
    }

    // Update is called once per frame
    void Update()
    {
        count = this.flag.transform.rotation.eulerAngles.y;
        Debug.Log("count�� " + count);

        if(count >= 359 || count <= 1)
        {
            num += 1;
        }
        
        this.flagturn.GetComponent<Text>().text = "��� ȸ�� Ƚ�� " + num.ToString()+ "ȸ";
    }
}
