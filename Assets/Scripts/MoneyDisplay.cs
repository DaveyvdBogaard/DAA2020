using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour
{
    public Text playerMoneyDisplay;
    public IntReference playerMoney;

    private void Start()
    {
        ChangeAmount(); 
    }

    public void ChangeAmount()
    {
        playerMoneyDisplay.text = "$" + playerMoney.value;
    }
}
