using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

	//Members
	public float speed =7.0f;
	public float maxDistance =0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
		maxDistance += 1 * Time.deltaTime;
		if(maxDistance >= 1)
		{
			Destroy(this
	}
}
