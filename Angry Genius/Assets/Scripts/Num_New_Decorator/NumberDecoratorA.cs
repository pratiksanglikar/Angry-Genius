using UnityEngine;
using System.Collections;

public class NumberDecorator : NewDecorator {
	protected GameObject gameObject;
	static int index = 0;
    string[] number_array;
    private DifficultyStrategy gameDifficulty;

    public NumberDecorator()
    {
        setArray();
    }

    public void setArray() {
        number_array = PlayerMovement.gameStrategy.getNumbersForAddition();
    }

	public override void Operation()
	{
		base.Operation();
		Debug.Log("ConcreteDecoratorA.Operation()");
	}

	public override GameObject getGameObject()
	{
		gameObject = base.getGameObject ();

		//int alphaspawnPointIndex = Random.Range (0, alphabate_array.Length);

		if (index >= number_array.Length) {
			index=0;
			Debug.Log("ConcreteDecoratorA.getGameObject()---"+"Displaying alphabate"+number_array[index]);
		}

		Material newMat = Resources.Load(number_array[index], typeof(Material)) as Material;

		gameObject.GetComponent<Renderer>().material = newMat;
		gameObject.name = number_array [index];
		index++;
	
		return gameObject;
	}
}
