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
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Equator")
        {
            FlipGravity();
        }
    }


    private void FlipGravity()
    {
        isAirborne = !isAirborne;

        if (isAirborne == true)
        {
            rb.gravityScale = 1;
        }
        else
        {
            rb.gravityScale = -1;
        }
    }
}
