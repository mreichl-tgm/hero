using UnityEngine;

public class CursorController : MonoBehaviour {
	void Update() {
		transform.position = Input.mousePosition;
	}
}
