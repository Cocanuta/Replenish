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
	public bool dangerZone;				// If the plant is at risk of dying.
	public int harvestLevel;			// What level of harvest the plant is at.
	public bool canClip;				// Can the plant be clipped.

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
		calculateGrowthLevel();
		growth();
	}

	// Calculates the growth level.
	public void calculateGrowthLevel()
	{
		int count = 0;
		int check = 0;

		foreach (Elements element in plantElements)
		{
			if (element.Equals(Elements.heat))
			{
				count ++;
			}
		}
		if (count.Equals(heatLevel))
		{
			check++;
		}

		count = 0;
		foreach (Elements element in plantElements)
		{
			if (element.Equals(Elements.water))
			{
				count ++;
			}
		}
		if (count.Equals(waterLevel))
		{
			check++;
		}

		count = 0;
		foreach (Elements element in plantElements)
		{
			if (element.Equals(Elements.light))
			{
				count ++;
			}
		}
		if (count.Equals(lightLevel))
		{
			check++;
		}

		plantGrowthLevel = check;
	}

	// Adjusts the plants growth based on growth level.
	public void growth()
	{
		if (plantGrowthLevel.Equals(0)) // Wilting.
		{
			alterGrowth(-0.01f);
		}
		if (plantGrowthLevel.Equals(1)) // Neutral
		{
		}
		if (plantGrowthLevel.Equals(2)) // Growth.
		{
			alterGrowth(0.01f);
		}
		if (plantGrowthLevel.Equals(3)) // Optimal Growth.
		{
			alterGrowth(0.02f);
		}
	}

	// Alters the growth value of the plant by a defined amount.
	public void alterGrowth(float growth)
	{
		plantGrowth += growth;

	
		if (plantGrowth >= 100.0f)
		{
			plantGrowth = 100.0f;
		}
		if (plantGrowth >= 80.0f)
		{
			harvestLevel = 2;
		}
		if (plantGrowth >= 70.0f)
		{
			canClip = true;
		}
		if (plantGrowth < 70.0f)
		{
			canClip = false;
		}
		if (plantGrowth >= 60.0f && plantGrowth < 80.0f)
		{
			harvestLevel = 1;
		}
		if (plantGrowth <= 60.0f)
		{
			harvestLevel = 0;
		}
		if (plantGrowth > 10.0f)
		{
			dangerZone = false;
		}
		if (plantGrowth <= 10.0f)
		{
			dangerZone = true;
		}
		if (plantGrowth <= 0.0f)
		{
			// DO SOMETHING TO MAKE THE PLANT DIE
		}
	}
}
