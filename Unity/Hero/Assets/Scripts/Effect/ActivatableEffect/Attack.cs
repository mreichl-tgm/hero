using UnityEngine;
using Hero.Util;

public class Attack : ActivatableEffect {
	
	[SerializeField]
	private GameObject projectile;
	[SerializeField]
	private float range;
	[SerializeField]
	private float rate;
	[SerializeField]
	private float speed;
	[SerializeField]
	private Navigable target;

	private float last = 0F;

	public override void Activate() {

		if (Time.time > last + rate / 100 - transform.root.GetComponent<Attributes>().agility / 100) {
			last = Time.time;

			Vector3 force = (target.position - transform.position).normalized;

			Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Atan2(force.y, force.x) * Mathf.Rad2Deg);

			GameObject instance = Instantiate(projectile, transform.position, rotation) as GameObject;
			instance.GetComponent<Rigidbody2D>().AddForce (force * speed);

			Destroy (instance, range / 10);
		}
	}
}