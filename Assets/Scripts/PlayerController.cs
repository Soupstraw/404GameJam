using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 6.0f;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        moveDirection *= speed;

        // move the character controller
        characterController.Move(moveDirection * Time.deltaTime);
    }
}