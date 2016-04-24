using UnityEngine;
using System.Collections;

public class GameClose : ICommand {

	private ISwitchable s;

	public GameClose (ISwitchable switchable)
	{
		s = switchable;
	}

	public void execute()
	{
		s.close ();
	}
}
