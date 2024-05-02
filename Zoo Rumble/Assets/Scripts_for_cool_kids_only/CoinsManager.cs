using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsManager : MonoBehaviour
{
    private GameObject player;
    public Text uiCoin;
    private int coin;
    TestCharControler scriptInstance = null;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        scriptInstance = player.GetComponent<TestCharControler>();
    }

    // Update is called once per frame
    void Update()
    {
        coin = scriptInstance.coins;
         uiCoin.text = "coins: " + coin.ToString();
    }
}
