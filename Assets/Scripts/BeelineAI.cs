using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movement))]
public class BeelineAI : MonoBehaviour {

	private Movement movement;
	private GameObject player;

	// Use this for initialization
	void Start () {
		movement = GetComponent<Movement>();
		player = GameObject.FindGameObjectWithTag("Player");
		if(player == null){
			Debug.Log("Player not found by tag.");
		}
	}
	
	// Update is called once per frame
	void Update () {
		movement.MoveTowards(player.transform.position);
	}
}
