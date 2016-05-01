using UnityEngine;
using System.Collections;

public class DifficultyLevelInvoker : IDifficultyLevelInvoker {

	private IDifficultyLevelCommand easy, medium, hard;

	public DifficultyLevelInvoker (IDifficultyLevelCommand e, IDifficultyLevelCommand m, IDifficultyLevelCommand h)
	{
		easy = e;
		medium = m;
		hard = h;
	}

	public void setEasyLevel()
	{
		easy.execute_level ();
	}

	public void setMediumLevel()
	{
		medium.execute_level ();
	}

	public void setHardLevel()
	{
		hard.execute_level ();
	}
}
