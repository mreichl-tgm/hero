using UnityEngine;

public class Attack : ActivatableEffect {

	[SerializeField]
	private GameObject projectile;
	[SerializeField]
	private float speed;

	public override void Activate() {
		Vector2 mousePos = Camera.main.WorldToScreenPoint(transform.position);
		Vector3 mousePosNormalized = new Vector3(Input.mousePosition.x - mousePos.x, Input.mousePosition.y - mousePos.y, 0).normalized;

		Vector3 origin = transform.position - mousePosNormalized;

		float angle = Mathf.Atan2(mousePosNormalized.y, mousePosNormalized.x) * Mathf.Rad2Deg;

		projectile.transform.rotation = Quaternion.Euler(0, 0, angle);

		Rigidbody2D projectile2D;
		projectile2D = Instantiate (projectile.GetComponent<Rigidbody2D>(), origin, projectile.transform.rotation) as Rigidbody2D;
		projectile2D.AddForce(mousePosNormalized * speed);
	}
}