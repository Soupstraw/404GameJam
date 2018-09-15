using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    CharacterController characterController;

    public Camera cam;
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

        // make the character look at the mouse position
        Vector3 playerScreenPos = cam.WorldToScreenPoint(transform.position);
        Vector3 lookAtVector = Input.mousePosition - playerScreenPos;

        transform.rotation = Quaternion.FromToRotation(Vector3.forward, new Vector3(lookAtVector.x,0, lookAtVector.y));
    }
}