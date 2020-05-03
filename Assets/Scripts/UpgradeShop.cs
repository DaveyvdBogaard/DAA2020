using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeShop : MonoBehaviour
{
    [Header("GameObject references")]
    public GameObject upgradeButton;
    public Text upgradeNameBox;
    public Text upgradePrice;

    [Header("Value references")]
    public SO_Upgrade upgrade;
    public IntReference playerMoney;
    public GameEvent moneyChange;

    private void Start()
    {
        upgradeButton.GetComponent<Image>().overrideSprite = upgrade.upgradeSprite;
        upgradeNameBox.text = upgrade.upgradeName;
        UpdateText();
    }

    public void UpdateText()
    {
        if (playerMoney.value >= upgrade.upgradePrice)
        {
            upgradeButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            upgradePrice.color = new Color32(0, 153, 39, 255);
        }

        else
        {
            upgradeButton.GetComponent<Image>().color = new Color32(65, 65, 65, 255);
            upgradePrice.color = new Color32(255, 0, 0, 255);
        }
        upgradePrice.text = "$" + upgrade.upgradePrice;
    }

    public void CallUpgrade(IntReference playerMoney)
    {
        upgrade.addValue(playerMoney);
        UpdateText();
        moneyChange.Raise();
    }
}
