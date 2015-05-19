using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Plant : MonoBehaviour {

	public int plantID; 				// The ID of the plant.
	public string plantName; 			// Then name of the plant.
	public List<Elements> plantElements;// The elements the plant reqiures.
	public float plantGrowth;			// How much growth the plant has.
	public int plantGrowthLevel;		// What growing condition the plant is in.
	public int heatLevel;				// The heat level of the plant.
	public int waterLevel;				// The water level of the plant.
	public int lightLevel;				// The light level of the plant.

	// The elements plants require.
	public enum Elements { heat, water, light };

	// Use this for initialization
	void Start () {
		// Set up the plant with default values.
		plantID = 0;
		plantName = "Plant";
		plantElements.Add(Elements.heat);
		plantElements.Add(Elements.water);
		plantElements.Add(Elements.light);
		plantGrowth = 5;
		heatLevel = 1;
		waterLevel = 1;
		lightLevel = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Calculates the growth level.
	void calculateGrowthLevel()
	{

	}

	// Adjusts the plants growth based on growth level.
	void growth()
	{
		if (plantGrowthLevel.Equals(0)) // Optimal wilting.
		{

		}
		if (plantGrowthLevel.Equals(1)) // Wilting
		{

		}
		if (plantGrowthLevel.Equals(2)) // Neutral.
		{
			
		}
		if (plantGrowthLevel.Equals(3)) // Growth.
		{
			
		}
		if (plantGrowthLevel.Equals(4)) // Optimal growth.
		{
			
		}
	}
}
