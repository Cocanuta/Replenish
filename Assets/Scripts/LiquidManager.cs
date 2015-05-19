using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LiquidManager : MonoBehaviour {

	public List<Liquid> liquids = new List<Liquid>();
	// Use this for initialization
	void Start () {

		AddNewLiquid ("None");
		AddNewLiquid ("Water");
		AddNewLiquid ("Oil");
		AddNewLiquid ("Sludge");
		AddNewLiquid ("Blood");
		AddNewLiquid ("Milk");
	
	}
	
	void AddNewLiquid(string name)
	{
		int id = 0;
		if (liquids.Count > 0) {
			foreach(Liquid l in liquids)
			{
				if(l.id >= id)
				{
					id = l.id + 1;
				}
			}
		}
		liquids.Add (new Liquid (id, name));
	}
}
