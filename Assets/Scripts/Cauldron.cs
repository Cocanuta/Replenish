using UnityEngine;
using System.Collections;

//Calls to constructor classes may need updated

public class Cauldron : MonoBehaviour {

	public float cauldronSize;			//The size of the cauldron.
	public float cauldronLevel;			//How full the cauldron is.
	public Liquid cauldronLiquid;		//Type of liquid in the cauldron.
	public Potion cauldronPotion;		//Type of potion in the cauldron.
	public Materials cauldronMats;		//Materials that can be in the cauldron.

	// Use this for initialization
	void Start () {
	//Set up the empty cauldron with the default size of 30L,
		cauldronSize = 30000.0f;
		cauldronLevel = 0.0f;
		cauldronLiquid = Liquid.none; 		//May need changed once liquid constructor is created 
		cauldronMats = Materials.none;		//May need changed once material constructor is created
		cauldronPotion = Potion.none;		//May need changed once potion constructor is created 	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Empties the cauldron
	void emptyCaldron () {
		cauldronLevel = 0.0f;
		cauldronLiquid = Liquid.none;
		cauldronMats = Materials.none;
		cauldronPotion = cauldronPotion.none;
	}

	//Fill the cauldron is liquid

}
