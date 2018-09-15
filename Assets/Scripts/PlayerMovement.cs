using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int hitPoints = 100;
    public float movementSpeed = 1f;

    private Transform transform;

    private void Start()
    {
        transform = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + Vector3.forward * Time.deltaTime * movementSpeed ;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + Vector3.left * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + Vector3.back * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + Vector3.right * Time.deltaTime * movementSpeed;
        }
    }

}
