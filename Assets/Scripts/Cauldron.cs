using UnityEngine;
using System.Collections;


//Calls to constructor classes may need updated

public class Cauldron : MonoBehaviour {
	public LiquidManager liquidManager;

	public float cauldronSize;			//The size of the cauldron.
	public float cauldronLevel;			//How full the cauldron is.
	public Liquid cauldronLiquid;		//Type of liquid in the cauldron.
	public Potion cauldronPotion;		//Type of potion in the cauldron.
	public Ingredients cauldronIngredients;		//Materials that can be in the cauldron.
	
	public enum Potion { none, health };
	public enum Ingredients { none, plant };

	// Use this for initialization
	void Start () {
	//Set up the empty cauldron with the default size of 30L,
		cauldronSize = 30000.0f;
		cauldronLevel = 0.0f;
		cauldronLiquid = liquidManager.liquids[0];
		cauldronIngredients = Ingredients.none;
		cauldronPotion = Potion.none; 	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Empties the cauldron
	void emptyCaldron () {
		cauldronLevel = 0.0f;
		cauldronLiquid = Liquid.none;
		cauldronMats = Ingredients.none;
		cauldronPotion = Potion.none;
	}

	//Fill the cauldron is liquid

}
