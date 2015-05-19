using UnityEngine;
using System.Collections;

public class Leak : MonoBehaviour {

	public float leakX;
	public float leakY;
	public float leakDuration;

	public Leak (float x, float y, float duration)
	{
		leakX = x;
		leakY = y;
		leakDuration = duration;
	}
}
