using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public Text gameOverText;
    public Text scoreText;
    public Text healthText;

    public static bool gameOver = false;

	// Use this for initialization
	void Start () {
        gameOverText.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (gameOver)
        {
            gameOverText.gameObject.SetActive(true);

            scoreText.gameObject.SetActive(false);
            healthText.gameObject.SetActive(false);
        }
	}
}
