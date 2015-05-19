using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IngredientManager : MonoBehaviour {
	
	public List<Ingredient> ingredients = new List<Ingredient>();
	// Use this for initialization
	void Start () {
		
		AddNewIngredient ("None");
	
	}
	
	void AddNewIngredient(string name)
	{
		int id = 0;
		if (ingredients.Count > 0) {
			foreach(Ingredient i in ingredients)
			{
				if(i.id >= id)
				{
					id = i.id + 1;
				}
			}
		}
		ingredients.Add (new Ingredient (id, name));
	}
}
