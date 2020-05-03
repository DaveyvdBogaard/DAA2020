using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddWorld : MonoBehaviour
{
    public Transform gridStartPoint;
    public Transform gridEndPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Vector3 newSpawnPos = gridEndPoint.position;
            AddTilemap(newSpawnPos);
        }
    }

    void AddTilemap(Vector3 spawnposition)
    {
        Instantiate(gridStartPoint, spawnposition, Quaternion.identity);
    }
}
