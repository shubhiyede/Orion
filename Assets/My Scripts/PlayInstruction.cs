using UnityEngine;
using System.Collections;

public class PlayInstruction : MonoBehaviour,ICommand {

	Menu menu = new Menu();
	
	public void execute()
	{
		menu.instruction ();
	}
}

