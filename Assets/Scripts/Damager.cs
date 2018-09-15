using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class Damager : MonoBehaviour {

	public UnityEvent onDamageDealt;
	public float damageAmount = 10f;

	void OnCollisionEnter(Collision col){
		Damagable damagable = col.collider.GetComponentInChildren<Damagable>();
		if(damagable != null){
			damagable.DealDamage(damageAmount);
			onDamageDealt.Invoke();
		}
	}
}
