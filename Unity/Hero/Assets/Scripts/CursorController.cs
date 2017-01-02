﻿using UnityEngine;

public class CursorController : MonoBehaviour {
	void Update() {
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = new Vector3(mousePosition.x, mousePosition.y, 0);
	}
}
