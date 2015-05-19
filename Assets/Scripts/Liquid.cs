using UnityEngine;
using System.Collections;
[System.Serializable]
public class Liquid{

	public int id;
	public string name;

	public Liquid(int newID, string newName)
	{
		id = newID;
		name = newName;
	}
}
