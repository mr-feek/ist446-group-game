﻿using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
	float fireRate = 0.3f;
	float nextFire = 0f;
	RaycastHit hit;
	float range = 300f;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		CheckForInput ();
	}

	void CheckForInput ()
	{
		if (Input.GetButton ("Fire1") && Time.time > nextFire) {
			Debug.DrawRay (transform.position, transform.forward, Color.green, 3f);
			if (Physics.Raycast (transform.position, transform.forward, out hit, range)) {
				if (hit.transform.CompareTag ("Enemy")) {
					Debug.Log ("Enemy " + hit.transform.name);
				} else {
					Debug.Log ("did not hit an enemy");
				}
			}
			nextFire = Time.time + fireRate;
		}
	}
}
