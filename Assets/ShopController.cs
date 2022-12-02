using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopController : MonoBehaviour
{
    [SerializeField]GameObject ShopPanel;
    private void Awake()
    {
        ShopPanel.SetActive(false);
    }
    public void ShopActive()
    {
        if (!ShopPanel.activeSelf)
        {
            ShopPanel.SetActive(true);
        }
        else if (ShopPanel.activeSelf)
        {
            ShopPanel.SetActive(false);
        }
    }

    public void BuyWeapon(int money)
    {
        CoinManager.coin += -money;
        CoinManager.addCoin = money;
    }
}
