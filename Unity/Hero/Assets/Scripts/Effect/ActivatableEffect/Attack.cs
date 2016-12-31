using UnityEngine;

public class Attack : ActivatableEffect {

	[SerializeField]
	private GameObject projectile;
	[SerializeField]
	private GameObject source;
	[SerializeField]
	private GameObject target;
	[SerializeField]
	private float speed;

	private Vector3 destination;
	private Vector3 origin;

	void Awake() {
		destination = target.transform.position;
		origin = source.transform.position;
	}

	public override void Activate() {
		Vector3 force = Camera.main.WorldToScreenPoint(origin - destination).normalized;

		float angle = Mathf.Atan2(force.y, force.x) * Mathf.Rad2Deg;

		projectile.transform.rotation = Quaternion.Euler(0, 0, angle);

		Rigidbody2D projectile2D;
		projectile2D = Instantiate (projectile.GetComponent<Rigidbody2D>(), origin, projectile.transform.rotation) as Rigidbody2D;
		projectile2D.AddForce(force * speed);
	}
}