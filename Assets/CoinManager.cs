using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinManager : MonoBehaviour
{
    [SerializeField]
    Text coinText;

    static public int coin;
    static public int addCoin;

    private void Awake()
    {
        coin = 1;
    }
    private void Update()
    {
        coinText.text = "Coin : " + coin.ToString();
    }
}
