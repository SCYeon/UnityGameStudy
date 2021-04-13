using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    GameObject player;
    GameObject yellowCat;
    GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.player = GameObject.Find("player");
        this.yellowCat = GameObject.Find("cat");
        this.distance = GameObject.Find("Distance");
    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
    public void IncreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount += 0.1f;
    }
    public void FullHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount = 1;
    }
    // Update is called once per frame
    void Update()
    {
        float length = this.player.transform.position.x - this.yellowCat.transform.position.x;
        this.distance.GetComponent<Text>().text = "Yellow cat과의 거리는 " + length.ToString("F2") + "m";
    }
}
