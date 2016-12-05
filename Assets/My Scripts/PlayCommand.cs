using UnityEngine;
using System.Collections;

public class PlayCommand : MonoBehaviour,ICommand {

	Menu menu = new Menu();

	public void execute()
	{
		menu.play ();
	}
}
