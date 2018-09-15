using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Damagable))]
public class IceCube : MonoBehaviour {

	public float targetScale = 1f;
	public float maxHealth = 100f;
	public float meltSpeed = 1f;

	private Damagable damagable;
	private float currentScale = 1f;

	// Use this for initialization
	void Start () {
		damagable = GetComponent<Damagable>();
	}
	
	// Update is called once per frame
	void Update () {
		targetScale = damagable.health / maxHealth;

		currentScale = Mathf.MoveTowards(currentScale, targetScale, Time.deltaTime * meltSpeed);
		transform.localScale = Vector3.one * currentScale;
	}
}
