using UnityEngine;
using System.Collections;

public class MediumLevel : IDifficultyLevelCommand {
	
	private IDifficultyLevelSwitchable e;
	
	public MediumLevel(IDifficultyLevelSwitchable es)
	{
		e = es;
	}
	
	public void execute_level()
	{
		e.mediumLevel ();
	}
}
