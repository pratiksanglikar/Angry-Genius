using UnityEngine;
using System.Collections;

public class NewDecorator:Component  {

	protected Component component;
	
	public void SetComponent(Component component)
	{
		this.component = component;
	}
	
	public override void Operation()
	{
		if (component != null)
		{
			component.Operation();
		}
	}

	public override GameObject getGameObject()
	{
		if (component != null) {
			//component.Operation();
			return component.getGameObject ();
		} else {

			return null;
		}
	}
		
		
	}


