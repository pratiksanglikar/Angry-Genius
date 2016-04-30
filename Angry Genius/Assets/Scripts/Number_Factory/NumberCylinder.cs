using UnityEngine;
using System.Collections;

public class NumberCylinder : MonoBehaviour,NumberFactory {

	public GameObject getGameObject(){
		
		return (GameObject)Instantiate(Resources.Load("NumberCylinder"));
	}
}
