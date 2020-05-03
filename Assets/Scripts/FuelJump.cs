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

    public FloatReference jumpForce;
    Rigidbody2D rb;
    public Transform fishTransform;

    public float jumpWaitTime = 1;
    private bool canJump = true;

    void Start()
    {
        fuel = startingFuel;
        fuelPercentage.value = fuel / startingFuel;
        rb = GetComponent<Rigidbody2D>();
    }

    public void jump()
    {
        if (canJump == true)
        {
            if (fuel >= 0 + fuelcost)
            {
                rb.AddForce(fishTransform.up * jumpForce.value, ForceMode2D.Impulse);
                fuel -= fuelcost;
                fuelPercentage.value = fuel / startingFuel;
                UIUpdate.Raise();
                StartCoroutine("BoostCooldown");
            }
        }
    }

    private IEnumerator BoostCooldown()
    {
        canJump = false;
        yield return new WaitForSeconds(jumpWaitTime);
        canJump = true;
    }
}
