using UnityEngine;
using System.Collections;

public class GameOpen : ICommand {

	private ISwitchable s;

	public GameOpen (ISwitchable switchable)
	{
		s = switchable;
	}

	public void execute()
	{
		s.start ();
	}

}
