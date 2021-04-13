using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    GameObject blackCat;

    // Start is called before the first frame update
    void Start()
    {
        this.blackCat = GameObject.Find("blackcat");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);
        }

        /* mostercat과 부딪힐때 사라지는 코드
        Vector2 p1 = transform.position;
        Vector2 p2 = this.blackCat.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 1.0f;
        float r2 = 2.0f;

        if (d < r1 + r2)
        {
            Destroy(gameObject);
        }
        */
    }
}
