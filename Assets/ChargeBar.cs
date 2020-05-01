﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeBar : MonoBehaviour
{
    public float maxSize;
    public float growFactor;
    public float waitTime;

    public float startPower = 10;

    void Start()
    {
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
                startPower++;
            }
            yield return new WaitForSeconds(waitTime);

            while (1 < transform.localScale.y)
            {
                transform.localScale -= new Vector3(0, 1 * Time.deltaTime * growFactor, 0);
                yield return null;
                startPower--;
            }
            yield return new WaitForSeconds(waitTime);
        }
    }
}
