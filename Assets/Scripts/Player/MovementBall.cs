using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBall : MonoBehaviour
{
    public int vel = 5;
    public int rotVel = 50;
    private Rigidbody pRB;

    void Start()
    {
        pRB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            BallRotation(-1);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            BallRotation(1);
        }
    }

    private void FixedUpdate()
    {
        BallMovement();
    }

    void BallMovement()
    {
        // Tomar inputs
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Mover en la dirección relativa a la rotación del objeto
        Vector3 move = (transform.forward * moveY + transform.right * moveX).normalized;

        // Aplicar la velocidad al Rigidbody
        pRB.velocity = move * vel;
    }

    void BallRotation(int direction)
    {
        transform.Rotate(Vector3.up * rotVel * direction * Time.deltaTime, Space.World);
    }
}
