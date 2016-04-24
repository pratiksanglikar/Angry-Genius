using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public bool isQuit=false;


	void OnMouseUp() {
		ISwitchable g = gameObject.AddComponent<Game>();
		ICommand c = new GameOpen(g);
		ICommand s = new GameClose(g);
		Invoker i = new Invoker(c,s);

		//is this quit
		if (isQuit==true) {
			//quit the game
			//Application.Quit();
			i.gameclose ();
			//i.gamestart ();
		}
		else 
		{
			//load level
			//Application.LoadLevel(1);
			i.gamestart ();
			//i.gameclose ();
		}
	}

	void Update()
	{
		//quit game if escape key is pressed
		if (Input.GetKey(KeyCode.Escape)) 
		{ 
			Application.Quit();
		}
	}

	void OnMouseEnter()
	{
		//change text color
		GetComponent<Renderer>().material.color=Color.red;
	}

	void OnMouseExit()
	{
		//change text color
		GetComponent<Renderer>().material.color=Color.white;
	}
}
