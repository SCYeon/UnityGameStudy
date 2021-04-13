using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCatController : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 1.0f;
        float r2 = 1.0f;

        if(d > r1 + r2)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.Translate(3, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.Translate(-3, 0, 0);
            }
        }
        else if (d <= r1 + r2)
        {
            transform.Translate(-6, 0, 0);
            this.player.transform.Translate(4, 0, 0);
        }
    }
}
