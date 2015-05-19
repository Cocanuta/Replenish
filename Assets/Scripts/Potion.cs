using UnityEngine;
using System.Collections;
[System.Serializable]
public class Potion{

	public int id;
	public string name;
	
	public Potion(int newID, string newName)
	{
		id = newID;
		name = newName;
	}

}
