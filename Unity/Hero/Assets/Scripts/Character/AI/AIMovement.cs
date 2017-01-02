using UnityEngine;
using Hero.Util;

public class AIMovement : MonoBehaviour {
	
	private Rigidbody2D rb2d;
	private GameObject target;

	void Awake() {
		rb2d = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate () {
		target = Util.ClosestGameObjectWithTag(this.gameObject, "Player");

		Vector3 force = (target.transform.position - transform.position).normalized;
		rb2d.velocity = new Vector2(force.x, force.y) * GetComponent<Attributes>().speed;
	}
}
