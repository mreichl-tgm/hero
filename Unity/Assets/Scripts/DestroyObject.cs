using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {

	void Start () {
		Destroy (gameObject, 1.2f);
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag != "Player" && other.gameObject.tag != "Projectile") {
			Destroy (other.gameObject);
			Destroy (gameObject, 0.015f);
		}
	}
}
