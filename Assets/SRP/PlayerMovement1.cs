using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 100f;  // Velocidad de movimiento
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()      // Movimiento en 4 direcciones utilizando el rigidbody
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            movement += transform.forward;
            Debug.Log("Moviendo arriba");
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement -= transform.right;
            Debug.Log("Moviendo izquierda");
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement -= transform.forward;
            Debug.Log("Moviendo abajo");
        }

        if (Input.GetKey(KeyCode.D))
        {
            movement += transform.right;
            Debug.Log("Moviendo derecha");
        }

        if (movement.magnitude > 1f)
        {
            movement.Normalize();
        }

        rb.AddForce(movement * moveSpeed, ForceMode.Acceleration);

        rb.MovePosition(rb.position + rb.velocity * Time.fixedDeltaTime);

    }
}
