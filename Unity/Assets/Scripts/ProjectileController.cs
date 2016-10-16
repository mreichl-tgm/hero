using UnityEngine;
using System.Collections;

public class ProjectileController : MonoBehaviour {

	public float speed;

	void Start () {
		Rigidbody2D rb2D = GetComponent<Rigidbody2D> ();
		rb2D.velocity = new Vector2(0, 1) * speed;
	}
}
