using UnityEngine;
using System.Collections;

public abstract class AbstractNumberState  {
	public abstract void attach(AbstractNumberObserver obj);
	public abstract void detach(AbstractNumberObserver obj);
	public abstract void notifyObservers();
}
