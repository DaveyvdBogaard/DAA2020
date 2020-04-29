using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [Header("Canvas references")]
    public Image fuelbar;
    public Text distance;

    [Header("Value references")]
    public FloatReference fuelPercentage;
    public FloatReference playerDistance;

    public void ChangeFuelbar()
    {
        fuelbar.fillAmount = fuelPercentage.value;
    }

    public void ChangeDistance()
    {
        distance.text = playerDistance.value.ToString("f1");
    }

}