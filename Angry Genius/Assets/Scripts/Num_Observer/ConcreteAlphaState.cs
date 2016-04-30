using UnityEngine;
using System.Collections;

public class ConcreteAlphaState : AbstractNumberState {

	private int subjectState;

	private ArrayList observers = new ArrayList();

	public override void attach(AbstractNumberObserver obj) {
		observers.Add (obj);
	}
	public override void detach(AbstractNumberObserver obj) {
		observers.Remove (obj);
	}

	public override void notifyObservers(){
		AbstractNumberObserver obj;
		if(observers!=null)
			for( int i=0;i<observers.Count;i++)
		{
			obj=(AbstractNumberObserver)observers[i];
			obj.update_observer();
		}
	}


	public int getState() {
		return subjectState ;
	}

    public void setState(int status) {
		subjectState = status;
		notifyObservers();
	}
}
