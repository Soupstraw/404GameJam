using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {
	
	public float lifetime = 2f;
	public float speed = 1f;

	private float age = 0.001f;

	void Start(){

		transform.localScale = Vector3.one * age;
		Debug.Log(transform.position);
	}

	// Update is called once per frame
	void FixedUpdate () {
		age += Time.deltaTime;

		if(age >= lifetime){
			Destroy(gameObject);
			return;
		}

		transform.localScale = Vector3.one * age;
		transform.localPosition = transform.localPosition + Vector3.forward * speed * Time.deltaTime / (age + 1);
	}
}
