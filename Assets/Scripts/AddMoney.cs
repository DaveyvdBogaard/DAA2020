using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMoney : MonoBehaviour
{
    public IntReference CurrentMoney;
    public FloatReference PlayerDistance;
    public IntReference RewardMultiplier;

    public void GiveMoney()
    {
        int DistanceInt = Mathf.FloorToInt(PlayerDistance.value);
        Debug.Log("give player money");
        CurrentMoney.value += DistanceInt;
    }
}
