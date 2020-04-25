using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerFuel playerFuel;
    Rigidbody2D rb;
    public Transform fishTransform;
    public int jumpForce;
    public int rotationForce;
    public float jumpWaitTime = 1;

    private bool canJump = true;
    Vector2 rotation;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Boost();
        Rotate();
    }

    private void Boost()
    {
        if (Input.GetKey(KeyCode.Space) && canJump && playerFuel.fuel > 0 && canJump)
        {
            rb.AddForce(fishTransform.up * jumpForce, ForceMode2D.Impulse);
            playerFuel.ChangeFuel(-10);
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
}
