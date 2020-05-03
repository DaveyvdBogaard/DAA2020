using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeBar : MonoBehaviour
{
    public float maxSize;
    public float growFactor;
    public float waitTime;

    [Header("Extra boost value")]
    // This is the power the fish should get when being shot
    public FloatReference startPower;
    public FloatReference statStartPower;

    void Start()
    {
        startPower.value = statStartPower.value;
        StartCoroutine(Scale());
    }
    private void Update()
    {
        
    }
    IEnumerator Scale()
    {
        while (true) // this could also be a condition indicating "alive or dead"
        {
            // we scale all axis, so they will have the same value, 
            // so we can work with a float instead of comparing vectors
            while (maxSize > transform.localScale.y)
            {
                transform.localScale += new Vector3(0, 1 * Time.deltaTime * growFactor, 0) ;
                yield return null;
                startPower.value+=1.5f;
            }
            yield return new WaitForSeconds(waitTime);

            while (1 < transform.localScale.y)
            {
                transform.localScale -= new Vector3(0, 1 * Time.deltaTime * growFactor, 0);
                yield return null;
                startPower.value-=1.5f;
            }
            yield return new WaitForSeconds(waitTime);
        }
    }
}
