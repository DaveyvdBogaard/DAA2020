using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public FuelJump playerJump;
    Rigidbody2D rb;
    public Transform fishTransform;
    public int rotationForce;
    public float jumpWaitTime = 1;

    private bool canJump = true;
    Vector2 rotation;
    private Vector3 velocity;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(fishTransform.up * 100, ForceMode2D.Impulse);
    }

    void Update()
    {
        Boost();
        Rotate();
        ChangeDrag();
    }

    private void Boost()
    {
        if (Input.GetKey(KeyCode.Space) && canJump)
        {
            
            StartCoroutine("BoostCooldown");
        }
    }

    private void Rotate()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            rotation.x = Input.GetAxisRaw("Horizontal");
            rb.AddTorque(rotation.x * -1 * rotationForce);
        }
    }

    private IEnumerator BoostCooldown()
    {
        canJump = false;
        yield return new WaitForSeconds(jumpWaitTime);
        canJump = true;
    }

    private void ChangeDrag()
    {
        velocity = rb.velocity;
        //Debug.Log("velocity = " + velocity);

        if (velocity.x < 5)
        {
            rb.drag = 3;
        }
    }
}
