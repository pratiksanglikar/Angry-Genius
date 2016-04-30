using UnityEngine;
using System.Collections;


public class DifficultyLevelMenu : MonoBehaviour {

	public bool Easy = false;
	public bool Medium = false;
	public bool Hard = false;


	void OnMouseUp() {
		IDifficultyLevelSwitchable l = gameObject.AddComponent<Level>();
		IDifficultyLevelCommand e = new EasyLevel (l);
		IDifficultyLevelCommand m = new MediumLevel (l);
		IDifficultyLevelCommand h = new HardLevel (l);

		DifficultyLevelInvoker i = new DifficultyLevelInvoker (e, m, h);

		if (Easy == true) {
			i.setEasyLevel();
			//Application.LoadLevel(1);
			//i.gamestart ();
		} else if (Medium == true) {
			i.setMediumLevel();
			//Application.LoadLevel(1);
			//i.gameclose ();
		} else {
		
			i.setHardLevel();
			//Application.LoadLevel(1);
		}
		Application.LoadLevel(3);
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
