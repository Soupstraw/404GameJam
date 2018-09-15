using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCamera : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
    public float smoothing = 5f; 

	// Use this for initialization
	void Start () {
        // Calculate the initial offset.
        offset = transform.position - player.transform.position;
	}
	
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        Vector3 targetCamPos = transform.position;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
