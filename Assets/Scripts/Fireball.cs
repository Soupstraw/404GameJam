using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {
	
	public float lifetime = 2f;
	public float speed = 5f;
	public Color startColor, endColor;

	private float age = 0.001f;
	private MeshRenderer rend;

	void Start(){
		rend = GetComponent<MeshRenderer>();

        // randomize the fireball position a little bit
        transform.position += new Vector3(Random.Range(-0.1f, 0.1f), 0, Random.Range(-0.1f, 0.1f));

		transform.localScale = Vector3.one * age;
	}

	// Update is called once per frame
	void FixedUpdate () {
		age += Time.deltaTime;

		if(age >= lifetime){
			Destroy(gameObject);
			return;
		}

		transform.localScale = Vector3.one * age;
		transform.localPosition = transform.localPosition + transform.forward * speed * Time.deltaTime / (age + 1);
		rend.material.color = Color.Lerp(startColor, endColor, age / lifetime);
	}
}
