using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class NumberTextManager : MonoBehaviour {

	public static int current_addition; 
	Text text;                      // Reference to the Text component.

	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		current_addition = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
		text.text = "CURRENT ADDITION: " + current_addition;
	}
}
