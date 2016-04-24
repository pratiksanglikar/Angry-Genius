using UnityEngine;
using System.Collections;

public class Invoker : IInvoker{

	private ICommand cls;
	private ICommand st;

	public Invoker(ICommand c,ICommand s)
	{
		cls = c;
		st = s;
	}

	public void gameclose()
	{
		cls.execute ();
	}
	public void gamestart()
	{
		st.execute ();
	}
}
