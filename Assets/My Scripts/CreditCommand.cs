using UnityEngine;
using System.Collections;

public class CreditCommand : MonoBehaviour,ICommand {
	
		
		Menu menu = new Menu();
		
		public void execute()
		{
		menu.credit ();
		}
}
