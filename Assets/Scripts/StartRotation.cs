using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRotation : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform fishTransform;
    public FloatReference maxFishRotation;
    public FloatReference minFishRotation;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        fishTransform = GetComponent<Transform>();
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
    private void FixedUpdate()
    {
        Aim();
    }

    private void Aim()
    {
        // rotate ro right
        if (Input.GetAxisRaw("Horizontal") > 0 && fishTransform.rotation.z >= minFishRotation.value)
        {
            fishTransform.rotation *= Quaternion.Euler(0, 0, -2);
        }
        // rotate to left
        else if (Input.GetAxisRaw("Horizontal") < 0 && fishTransform.rotation.z <= maxFishRotation.value)
        {
            fishTransform.rotation *= Quaternion.Euler(0, 0, 2);
        }
        
    }
    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.AddForce(fishTransform.up * 100, ForceMode2D.Impulse);
            GetComponent<PlayerMovement>().enabled = true;
            GetComponent<StartRotation>().enabled = false;
        }
    }
}
