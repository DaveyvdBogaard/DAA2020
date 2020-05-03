using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMoney : MonoBehaviour
{
    public IntReference CurrentMoney;
    public FloatReference PlayerDistance;
    public FloatReference RewardMultiplier;

    public void GiveMoney()
    {
        int DistanceInt = Mathf.FloorToInt(PlayerDistance.value * RewardMultiplier.value);
        Debug.Log("give player money");
        CurrentMoney.value += DistanceInt;
    }
}
