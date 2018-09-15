using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Damager : MonoBehaviour {

	public float damageAmount = 10f;

	void OnCollisionEnter(Collision col){
		Damagable damagable = col.collider.GetComponentInChildren<Damagable>();
		if(damagable != null){
			damagable.DealDamage(damageAmount);
		}
	}
}
