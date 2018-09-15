using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class Damager : MonoBehaviour {

	public enum TeamEnum{
		PLAYER,
		ENEMY
	}

	public UnityEvent onDamageDealt;
	public float damageAmount = 10f;
	public TeamEnum team;

	private void DealDamage(Collider col){
		Damagable damagable = col.GetComponentInChildren<Damagable>();
		if(damagable != null && damagable.team != team){
			damagable.DealDamage(damageAmount);
			onDamageDealt.Invoke();
		}
	}

	void OnCollisionEnter(Collision col){
		DealDamage(col.collider);
	}

	void OnTriggerEnter(Collider col){
		DealDamage(col);
	}
}
