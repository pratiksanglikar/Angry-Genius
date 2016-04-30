using UnityEngine;
using System.Collections;

public class NumberSphere : MonoBehaviour,NumberFactory {

	public GameObject getGameObject(){
		
		return (GameObject)Instantiate(Resources.Load("NumberSphere"));
	}
}
