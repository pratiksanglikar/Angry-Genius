using UnityEngine;
using System.Collections;

public class NumTextGenImpl : NumTextGen {
    protected int number_array = PlayerMovement.gameStrategy.getTarget();
    public static int count = -1;
	
	public override int getTargetNumber(){
		return number_array;
	}
}
