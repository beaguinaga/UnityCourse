using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
		void Example() {
        Screen.showCursor = false;
    }

	public void LoadLevel(string name) {
		Debug.Log("New level load: " + name);
		Brick.breakableCount = 0;
		Application.LoadLevel(name);
	}
	
	public void QuitRequest() {
		Debug.Log("Quit requested.");
		Application.Quit();
	}
	
	public void LoadNextLevel() {
		Brick.breakableCount = 0;
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void BrickDestroyed() {
		if (Brick.breakableCount <= 0) {
			LoadNextLevel();
		}
	}
}
