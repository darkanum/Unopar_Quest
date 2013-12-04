using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {


	public float velocity; 

	// Update is called once per frame
	void Update () {
	
		transform.RotateAround(new Vector3(0,0,0), new Vector3(1,1,-1), velocity * Time.deltaTime);
	}
}
