using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

    public GameObject player;
    public float deadzone;

    private Camera cam;
    private Vector3 offset;
    
	void Start ()
    {
        cam = GetComponent<Camera>();

        // Calculate the initial offset.
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        // get the screen mouse position
        Vector3 playerScreenPos = cam.WorldToScreenPoint(player.transform.position);
        Vector3 lookAtVector = Input.mousePosition - playerScreenPos;

        // set the camera position to be between the mouse and player
        transform.position = player.transform.position + offset + 
            new Vector3(
                lookAtVector.x / deadzone, 0, lookAtVector.y / deadzone);
    }
}
