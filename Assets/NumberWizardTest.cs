using UnityEngine;
using System.Collections;

public class NumberWizardTest : MonoBehaviour {
	
	int max;
	int min;
	int guess;
		
	void StartGame() {
		max = 1001;
		min = 1;
		guess = Random.Range(min, 1000);
		
		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head, but don't tell me!");
		
		print("The default range is between 1 and 1000");
		print ("P = Play; Space = Change range");
		
		
			
				
		print ("Is the number higher or lower than " + guess + " ?");
				
		print ("Up = higher; Down = lower; Return = equal");
		}
		
		void NextGuess() {
			guess = Random.Range(min, max);
			print ("Is the number higher or lower than " + guess + " ?");
		}
		
		void ChangeRange() {
			
			if(Input.GetKeyDown (KeyCode.Space)) {
				print ("Press 'Q' to increase maximum by 10; 'W' by 100; 'E' by 1000");
				print ("Press 'A' to decrease maximum by 10; 'S' by 100; 'D' by 1000");
			}
			else if (Input.GetKeyDown(KeyCode.Q)) {
				max = max + 10;
				print ("Current range is 0 - " + (max - 1));
			}
			else if (Input.GetKeyDown(KeyCode.W)) {
				max = max + 100;
				print ("Current range is 0 - " + (max - 1));
			}
			else if (Input.GetKeyDown(KeyCode.E)) {
				max = max + 1000;
				print ("Current range is 0 - " + (max - 1));
			}
			else if (Input.GetKeyDown(KeyCode.A)) {
				max = max - 10;
				print ("Current range is 0 - " + (max - 1));
			}
			else if (Input.GetKeyDown(KeyCode.S)) {
				max = max - 100;
				print ("Current range is 0 - " + (max - 1));
			}
			else if (Input.GetKeyDown(KeyCode.D)) {
				max = max - 1000;
				print ("Current range is 0 - " + (max - 1));
			}
			else if (Input.GetKeyDown(KeyCode.P)) {
			print ("Let's play!");
			NextGuess();
			}					
		
		}
	
	// Use this for initialization
	void Start () {
			StartGame();
		}
		
		// Update is called once per frame
		void Update () {
			ChangeRange ();
			
			if(Input.GetKeyDown(KeyCode.UpArrow)) {
				//print("Up arrow was pressed");
				min = guess;
				NextGuess();			
			}
			else if(Input.GetKeyDown(KeyCode.DownArrow)) {
				//print("Down arrow was pressed");
				max = guess;
				NextGuess();
			}
			else if(Input.GetKeyDown(KeyCode.Return)) {
				print("I won!");
				print ("=========================================");
				print ("Let's start again!");
				/*max = 1001;
				min = 1;
				guess = Random.Range(min, 1000); */
				StartGame ();
			}
		}
	}