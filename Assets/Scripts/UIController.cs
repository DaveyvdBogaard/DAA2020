using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Image fuelbar;
    public FloatReference fuelPercentage;

    public void ChangeFuelbar()
    {
        fuelbar.fillAmount = fuelPercentage.value;
    }
}
