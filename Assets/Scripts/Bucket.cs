using UnityEngine;
using System.Collections;

public class Bucket : MonoBehaviour {

	public float bucketSize;	// The size of the bucket.
	public float bucketFill; 	// How full the bucket is.
	public Liquid bucketLiquid;	// What is in the bucket.

	// The types of liquid.
	public enum Liquid { none, water, sludge };

	// Use this for initialization
	void Start () {
		// Set up the bucket with a default size of 10L, empty, with no liquid type.
		bucketSize = 10000.0f;
		bucketFill = 0.0f;
		bucketLiquid = Liquid.none;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Empties the bucket completely.
	void emptyBucket()
	{
		bucketFill = 0.0f;
		bucketLiquid = Liquid.none;
	}

	// Empties the bucket partially.
	void emptyBucket(float amount)
	{
		// If the amount is bigger than the amount in the bucket, empty thr bucket completely.
		if (amount >= bucketFill)
		{
			emptyBucket();
		}
		// Otherwise, subtract the amount from the bucket amount.
		else
		{
			bucketFill -= amount;
		}
	}

	// Fills the bucket completely with the specified liquid.
	void fillBucket(Liquid liquid)
	{
		// If the bucket already has liquid in that is not equal to the liquid specified, do not fill.
		if (bucketLiquid.Equals(liquid) || bucketLiquid.Equals(Liquid.none))
		{
			bucketFill = bucketSize;
			bucketLiquid = liquid;
		}
		else
		{
			return;
		}
	}

	// Fills the bucket with the specified amount and type of liquid.
	void fillBucket(float amount, Liquid liquid)
	{
		// If the amount is bigger than the amount left in the bucket, fill thr bucket completely.
		if (amount >= bucketAmount - bucketFill)
		{
			fillBucket(liquid);
		}
		// Otherwise, fill the bucket with the specified amount.
		else
		{
			// If the bucket already has liquid in that is not equal to the liquid specified, do not fill.
			if (bucketLiquid.Equals(liquid) || bucketLiquid.Equals(Liquid.none))
			{
				bucketFill += amount;
				bucketLiquid = liquid;
			}
			else
			{
				return;
			}
		}
	}
}
