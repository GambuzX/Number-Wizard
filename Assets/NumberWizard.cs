using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	public int maxGuessesAllowed = 10;
	
	public Text text;
	
	void StartGame() {
		max = Maximum.Data.max;
		min = 1;
		guess = Random.Range(min, max);
		text.text = guess.ToString();
		}
		
	void NextGuess() {
		if (maxGuessesAllowed <= 0) { Application.LoadLevel ("Win"); }
		guess = Random.Range(min, max);
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		}
		
	public void GuessHigher() {
		min = guess;
		NextGuess();
	}
	public void GuessLower() {
		max = guess;
		NextGuess();
	}
	
	void Start () {
		StartGame();
	}
}