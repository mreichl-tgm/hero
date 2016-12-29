using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {

	void Start () {
		Destroy (gameObject, 3f);

	}

	void OnTriggerEnter2D(Collider2D other) {
		if (gameObject.tag != other.gameObject.tag) {
		//if (other.gameObject.tag != "Player" && other.gameObject.tag != "Projectile") {
			Destroy (other.gameObject);
			Destroy (gameObject, 0.015f);
		}
	}
}
