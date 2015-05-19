using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PotionManager : MonoBehaviour {

	public List<Potion> potions = new List<Potion>();
	// Use this for initialization
	void Start () {
	
		AddNewPotion ("Health");
		AddNewPotion ("Mana");

	}
	
	void AddNewPotion(string name)
	{
		int id = 0;
		if (potions.Count > 0) {
			foreach(Potion p in potions)
			{
				if(p.id >= id)
				{
					id = p.id + 1;
				}
			}
		}
		potions.Add (new Potion (id, name));
	}
}
