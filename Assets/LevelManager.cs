using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log ("Potatoes are good! State: " + name);
		Application.LoadLevel(name);
	}
	public void QuitRequest () {
		Debug.Log ("I quit!");
		Application.Quit ();
	}
	

}