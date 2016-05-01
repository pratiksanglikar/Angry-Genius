using UnityEngine;
using System.Collections;

public class HardLevel : IDifficultyLevelCommand {
	
	private IDifficultyLevelSwitchable e;
	
	public HardLevel(IDifficultyLevelSwitchable es)
	{
		e = es;
	}
	
	public void execute_level()
	{
		e.hardLevel ();
	}

}
