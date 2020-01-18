using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hpbar : MonoBehaviour
{
    public GameObject player;
    private Hp _hp;
    GameObject hpGauge;

    // Start is called before the first frame update
    void Start()
    {
        _hp = player.GetComponent<Hp>();
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    void Update()
    {
        this.hpGauge.GetComponent<Image>().fillAmount = _hp.getHp()/100f;
    }

    public void DecreaseHp()
    {
    }
}
