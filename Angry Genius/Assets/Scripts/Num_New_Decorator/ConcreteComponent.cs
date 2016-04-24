using UnityEngine;
using System.Collections;

public class ConcreteComponent :Component {

	protected GameObject gameObject;

	public ConcreteComponent(GameObject gameObject){

		this.gameObject = gameObject;
	}

	public override void Operation()
	{
		Debug.Log("ConcreteComponent.Operation()");
	}

	public override GameObject getGameObject()
	{
		Debug.Log("ConcreteComponent.getGameObject()");
		return gameObject;
	}
}
