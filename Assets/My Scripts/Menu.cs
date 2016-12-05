using UnityEngine;
using System.Collections;

public class Menu : Imenu {

public void play()
	{
		Application.LoadLevel ("Earth_Magnetic_Field");
	}
	
	public  void instruction()
	{
		Application.LoadLevel ("Instruction");
	}

public	void credit()
	{
		Application.LoadLevel ("credits");
	}

public	void exit()
	{
		Application.Quit ();
	}
}
