using UnityEngine;
using System.Collections;

public class ColorDecorator : NewDecorator {

	protected GameObject gameObject;
    static System.Random rnd = new System.Random();
    int color = rnd.Next(0, 4);

	public override void Operation()
	{
		base.Operation();
		Debug.Log("ConcreteDecoratorB.Operation()");
	}
	
	public override GameObject getGameObject()
	{
		gameObject = base.getGameObject ();
		
		gameObject.tag="Pickup";

        if (color == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
        else if (color == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (color == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (color == 3)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        return gameObject;
	}
}
