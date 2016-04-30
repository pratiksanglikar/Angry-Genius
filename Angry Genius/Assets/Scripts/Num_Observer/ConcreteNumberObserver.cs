using UnityEngine;
using System.Collections;

public class ConcreteNumberObserver : AbstractNumberObserver {
    protected ConcreteAlphaState state;

	public override void update_observer(){


	}



	
	public ConcreteNumberObserver(){
		
	}
	
	public ConcreteNumberObserver( ConcreteAlphaState theSubject )
	{
		this.state = theSubject ;
	}
}
