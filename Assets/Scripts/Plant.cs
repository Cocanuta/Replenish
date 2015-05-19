using UnityEngine;
using System.Collections;

public class Plant : MonoBehaviour {

	public int plantID; 				// The ID of the plant.
	public string plantName; 			// Then name of the plant.
	public Elements[] plantElements;	// The elements the plant reqiures.
	public float plantGrowth;			// How much growth the plant has.

	// The elements plants require.
	public enum Elements { heat, water, light };

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
