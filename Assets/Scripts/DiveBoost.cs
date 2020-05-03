using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiveBoost : MonoBehaviour
{
    Rigidbody2D rb;
    Transform fishTransform;
    public IntReference diveBoostForce;

    private float pastHeight;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        fishTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("PastHeight");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Equator" && pastHeight > 5)
        {
            rb.AddForce(fishTransform.up * diveBoostForce.value, ForceMode2D.Impulse);
        }
    }
    IEnumerator PastHeight()
    {
        yield return new WaitForSeconds(1f);
        pastHeight = transform.position.y;
    }
}
