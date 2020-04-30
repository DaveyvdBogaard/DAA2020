using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCounter : MonoBehaviour
{
    public GameObject player;
    public FloatReference distance;

    public GameEvent UIUpdate;

    private Transform playerPosition;

    private void Update()
    {
        CalculateDistance();
        UIUpdate.Raise();
    }

    public void CalculateDistance()
    {
        playerPosition = player.GetComponent<Transform>();
        distance.value = playerPosition.position.x - this.transform.position.x;
    }
}
