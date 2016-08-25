using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	public static int currentLevel;

	private LevelManager levelManager;
	
	void OnTriggerEnter2D(Collider2D trigger) {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		levelManager.LoadLevel("Lose");

		currentLevel = Application.loadedLevel;
	}

	void OnCollisionEnter2D(Collision2D collision) {

	}

}
