using UnityEngine;
using System.Collections;

public class NumberCube : MonoBehaviour,NumberFactory {

	public GameObject getGameObject(){

		return (GameObject)Instantiate(Resources.Load("NumberCube"));
	}

}
