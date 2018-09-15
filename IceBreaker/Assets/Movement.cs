using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float moveSpeed = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MoveTowards(Vector3 position){
		transform.position = Vector3.MoveTowards(transform.position, position, Time.deltaTime * moveSpeed);
	}
}
