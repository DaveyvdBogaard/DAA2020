using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleOnCollide : MonoBehaviour
{
    public ParticleSystem ps;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Equator")
        {
            Instantiate(ps, rb.position, Quaternion.Euler(-90, 0, 0));
        }
    }
}
