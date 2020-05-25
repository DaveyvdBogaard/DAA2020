using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Upgrade", menuName = "ScriptableObjects/Upgrade", order = 51)]
public class SO_Upgrade : ScriptableObject
{
    public FloatReference upgradeStat;
    public string upgradeName;
    public Sprite upgradeSprite;
    public int upgradePrice;
    public float priceMultiplier;
    public float valueMultiplier;

    public void addValue(IntReference PlayerMoney)
    {
        if (PlayerMoney.value >= upgradePrice)
        {
            PlayerMoney.value = PlayerMoney.value - upgradePrice;
            upgradeStat.value = upgradeStat.value * valueMultiplier;
            upgradePrice = Mathf.CeilToInt(upgradePrice * priceMultiplier);
        }
    }
}
