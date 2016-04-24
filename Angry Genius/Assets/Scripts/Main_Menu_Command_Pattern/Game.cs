using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour, ISwitchable{

	public void start()
	{
		Application.LoadLevel (2);
	}

	public void close()
	{
		Application.Quit();
	}
}
