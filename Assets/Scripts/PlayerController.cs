using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody playerRB;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        playerRB.AddForce(movement * speed);
    }
}