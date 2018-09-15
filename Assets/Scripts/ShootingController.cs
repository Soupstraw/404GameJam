using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour {

	public GameObject fireballPrefab;
	public float cooldown = 0.1f;
	public Transform gunTransform;

	private float lastFired = 0f;
    
	void Update () {
		lastFired += Time.deltaTime;

		if(Input.GetButton("Fire1") && lastFired >= cooldown){
			GameObject fireball = Instantiate(fireballPrefab, gunTransform.position, gunTransform.rotation);
            
			lastFired = 0f;
		}
	}
}
