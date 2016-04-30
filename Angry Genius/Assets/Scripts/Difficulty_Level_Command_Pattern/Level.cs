using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour,IDifficultyLevelSwitchable {

	public static bool isEasy=false;
	public static bool isMedium=false;
	public static bool isHard=false;

	public void easyLevel (){
		isEasy = true;
	}
	public void mediumLevel (){
		isMedium = true;
		Debug.Log("Setting true");
	}
	public void hardLevel (){
		isHard = true;
	}
}
