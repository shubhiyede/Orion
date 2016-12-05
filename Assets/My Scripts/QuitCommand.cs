using UnityEngine;
using System.Collections;

public class QuitCommand : MonoBehaviour,ICommand  {

	Menu menu = new Menu();

public void execute()
	{
		menu.exit ();
	}
}
