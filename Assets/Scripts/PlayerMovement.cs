using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public SceneLoader sceneLoader;
    public FuelJump playerJump;
    Rigidbody2D rb;
    public Transform fishTransform;
    public int rotationForce;
    public DiveBoost diveBoost;
    public AddMoney addMoney;
   
    Vector2 rotation;
    private Vector3 velocity;

    bool stopped = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Boost();
        Rotate();
        ChangeDrag();
    }

    private void Boost()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            playerJump.jump();
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

    private void ChangeDrag()
    {
        velocity = rb.velocity;
        if (velocity.x < 5 && transform.position.y < 5f && stopped == false)
        {
            StartCoroutine("WaitToLoadScene");
            rb.drag = 3;
            stopped = true;
        }
    }

    private IEnumerator WaitToLoadScene()
    {
        addMoney.GiveMoney();
        yield return new WaitForSeconds(3);
        sceneLoader.LoadScene("Shop");
    }
}
