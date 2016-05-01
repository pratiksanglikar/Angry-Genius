using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AlphaTargetTextManager : MonoBehaviour {

	public static int target_number; 
	Text text;     
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		target_number = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = "TARGET: " + target_number;
	}
}
