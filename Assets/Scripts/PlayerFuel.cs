using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFuel : MonoBehaviour
{
    public UIController UIController;
    public float startingFuel;
    public float fuel;

    void Start()
    {
        fuel = startingFuel;
    }

    public void ChangeFuel(float fuelChange)
    {
        if (fuel <= startingFuel)
        {
            fuel += fuelChange;
            float percentage = fuel / startingFuel;
            UIController.ChangeFuelbar(percentage);
        }
    }
}
