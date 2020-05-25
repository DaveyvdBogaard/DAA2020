using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    Rigidbody2D rb;
    private bool isAirborne = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        FlipGravity();
    }
    private void FlipGravity()
    {
        if (transform.position.y > 0.26)
        {
            rb.gravityScale = 1;
        }
        else
        {
            rb.gravityScale = -1;
        }
    }
}
