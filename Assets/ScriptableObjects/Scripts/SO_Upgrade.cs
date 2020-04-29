using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Upgrade", menuName = "ScriptableObjects/Upgrade", order = 51)]
public class SO_Upgrade : ScriptableObject
{
    public float value;
    public string upgradeName;
    public Sprite upgradeSprite;
    public int upgradePrice;
}
