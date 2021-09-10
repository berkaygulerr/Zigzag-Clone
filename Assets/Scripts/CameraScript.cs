using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    float distance;

    void Start()
    {
        distance = transform.position.x - player.transform.position.x;
    }
    void Update()
    {
        float offset = ((player.transform.position.x + player.transform.position.z) / 2) + distance;

        if (player.GetComponent<Rigidbody>().velocity.y >= -0.1)
        {
            transform.position = new Vector3(offset, transform.position.y, offset);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
