using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    bool flag = false;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > -4 || transform.position.y < 4)
        {
            if(flag == false)
            {
                transform.Translate(0, -0.05f, 0);
            }
            else if(flag == true)
            {
                transform.Translate(0, 0.05f, 0);
            }
        }
        if (transform.position.y <= -4 || transform.position.y >= 4)
        {
            if(flag == false)
            {
                flag = true;
            }
            else if(flag == true)
            {
                flag = false;
            }
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().FullHp();
        }

    }
}