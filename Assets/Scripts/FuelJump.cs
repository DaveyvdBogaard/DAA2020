using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelJump : MonoBehaviour
{
    public GameEvent UIUpdate;
    public FloatReference fuelPercentage;
    public FloatReference fuelStat;
    public float startingFuel;
    public float fuel;
    public float fuelcost;
    public AudioSource audio;

    public FloatReference jumpForce;
    Rigidbody2D rb;
    public Transform fishTransform;

    public float jumpWaitTime = 1;
    private bool canJump = true;

    void Start()
    {
        startingFuel = fuelStat.value;
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
                float randomPitch = Random.Range(0.9f, 1.1f);
                audio.pitch = randomPitch;
                audio.Play();
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
