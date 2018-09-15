using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthDisplay : MonoBehaviour {

	private Damagable playerDamagable;
	private Text healthText;

	// Use this for initialization
	void Start () {
		playerDamagable = GameObject.FindGameObjectWithTag("Player").GetComponent<Damagable>();
		healthText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		healthText.text = "Health: " + playerDamagable.health;
	}
}
