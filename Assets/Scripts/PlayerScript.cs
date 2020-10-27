using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float forwardSpeed = 3f;
    [SerializeField] float speed = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.position += Vector2.up * forwardSpeed * Time.deltaTime;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.position += Vector2.left * speed * Time.deltaTime;
            rb.position = new Vector3(Mathf.Clamp(rb.position.x, -0.632f, + 0.632f), rb.position.y, 0);
            rb.MoveRotation(-45);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.position += Vector2.right * speed * Time.deltaTime;
            rb.position = new Vector3(Mathf.Clamp(rb.position.x, -0.632f, +0.632f), rb.position.y, 0);
            rb.MoveRotation(45);
        }
        else
            rb.MoveRotation(0);
    }
}
