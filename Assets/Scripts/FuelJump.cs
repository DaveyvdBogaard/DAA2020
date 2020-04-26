using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelJump : MonoBehaviour
{
    public GameEvent UIUpdate;
    public FloatReference fuelPercentage;
    public float startingFuel;
    public float fuel;
    public float fuelcost;

    public int jumpForce;
    Rigidbody2D rb;
    public Transform fishTransform;

    void Start()
    {
        fuel = startingFuel;
        fuelPercentage.value = fuel / startingFuel;
        rb = GetComponent<Rigidbody2D>();
    }

    public void ChangeFuel()
    {
        if (fuel >= 0 + fuelcost)
        {
            rb.AddForce(fishTransform.up * jumpForce, ForceMode2D.Impulse);
            fuel -= fuelcost;
            fuelPercentage.value = fuel / startingFuel;
            UIUpdate.Raise();
        }
    }
}
