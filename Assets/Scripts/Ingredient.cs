using UnityEngine;
using System.Collections;
[System.Serializable]
public class Ingredient {

	public int id;
	public string name;
	
	public Ingredient(int newID, string newName)
	{
		id = newID;
		name = newName;
	}
	
}

