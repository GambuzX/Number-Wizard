using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Maximum : MonoBehaviour {

	public Text text;
	public static class Data {
		public static int max = 1000;
		}
	
	public void Plus10() { Data.max = Data.max + 10; }
	public void Plus100() { Data.max = Data.max + 100; }
	public void Plus1000() { Data.max = Data.max + 1000; }
	public void Minus10() { Data.max = Data.max - 10; }
	public void Minus100() { Data.max = Data.max - 100; }
	public void Minus1000() { Data.max = Data.max - 1000; }
	
	// Use this for initialization
	void Start () {
		text.text = Data.max.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Data.max <=0) { Data.max = 1; }
		text.text = Data.max.ToString ();
	}
}
