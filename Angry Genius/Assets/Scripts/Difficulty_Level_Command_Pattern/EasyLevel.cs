using UnityEngine;
using System.Collections;

public class EasyLevel : IDifficultyLevelCommand {

	private IDifficultyLevelSwitchable e;

	public EasyLevel(IDifficultyLevelSwitchable es)
	{
		e = es;
	}

	public void execute_level()
	{
		e.easyLevel ();
	}
}
