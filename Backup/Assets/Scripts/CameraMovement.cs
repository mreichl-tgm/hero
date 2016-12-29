﻿using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public Transform target;
	void Update () {
		//Camera position = Player position
		if (target != null)
			transform.position = new Vector3 (target.position.x, target.position.y, transform.position.z);
	}
}
