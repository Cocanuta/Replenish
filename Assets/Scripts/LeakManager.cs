using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class LeakManager : MonoBehaviour {

	public Object leak;

	public Transform left;
	public Transform right;
	public Transform top;
	public Transform bottom;

	public int leakCount = 3;

	public bool isTimerRunning = false;

	// Use this for initialization
	void Start () {
		createLeak();
		createLeak();
		createLeak();	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void createLeak()
	{
		float x = (float)Random.Range (left.position.x+0.5f, right.position.x-0.5f);
		float z = (float)Random.Range (bottom.position.z-0.5f, top.position.z+0.5f);
		Object newLeak = Instantiate (leak, new Vector3 (x,6.0f, z), Quaternion.AngleAxis(-90.0f, Vector3.left));
		StartCoroutine(leakTimer(newLeak));
	}

	IEnumerator leakTimer(Object leak)
	{
		yield return new WaitForSeconds(Random.Range(60,120));
		Destroy(leak);
		createLeak();
	}
}
