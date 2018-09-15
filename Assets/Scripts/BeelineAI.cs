using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movement))]
[RequireComponent(typeof(Rigidbody))]
public class BeelineAI : MonoBehaviour {

	private Movement movement;
	private GameObject player;
	private Rigidbody rigidbody;

	public float knockbackForce = 10f;
	public float attackCooldown = 1f;

	private bool canMove = true;

	// Use this for initialization
	void Start () {
		movement = GetComponent<Movement>();
		player = GameObject.FindGameObjectWithTag("Player");
		rigidbody = GetComponent<Rigidbody>();

		if(player == null){
			Debug.Log("Player not found by tag.");
		}
	}
	
	// Update is called once per frame
	void Update () {
		movement.MoveTowards(player.transform.position);
	}

	public void AttackCooldown(){
		StartCoroutine(AttackCooldownCoroutine());
	}

	private IEnumerator AttackCooldownCoroutine(){
		movement.enabled = false;
		rigidbody.AddForce((transform.position - player.transform.position).normalized * knockbackForce);
		yield return new WaitForSeconds(attackCooldown);
		movement.enabled = true;
	}
}
