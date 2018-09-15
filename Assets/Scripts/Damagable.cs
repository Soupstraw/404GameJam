using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagable : MonoBehaviour {

	public float health = 100f;
	public Damager.TeamEnum team;

	public void DealDamage(float damage){
		health -= damage;
		if(health <= 0){
			Die();
		}
	}

	void Die(){
		GameObject.Destroy(gameObject);
	}
}
