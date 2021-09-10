using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Vector3 playerDir;
    public float speed;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerDir = Vector3.zero;
    }
    void Update()
    {
        PlayerMovement();
    }

    public void PlayerMovement()
    {
        if (Input.GetMouseButtonDown(0) && rb.velocity.y > -0.1f)
        {
            if (playerDir == Vector3.right)
            {
                playerDir = Vector3.forward;
            }
            else
            {
                playerDir = Vector3.right;
            }
        }
        else if (rb.velocity.y < -0.1f)
        {
            rb.velocity += Vector3.up * -1.05f;
        }

        transform.Translate(playerDir * speed * Time.deltaTime);
    }
}
