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
	[SerializeField]
	private float range;
	[SerializeField]
	private float rate;

	private float last;
	private bool active;

	public override void Activate() {
		active = !active;
	}

	void Awake() {
		active = false;
		last = 0F;
	}

	void FixedUpdate() {
		if (active && Time.time > last + rate / 100 - source.GetComponent<Attributes>().agility / 100) {
			last = Time.time;

			Vector3 force = (target.transform.position - source.transform.position).normalized;

			Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Atan2(force.y, force.x) * Mathf.Rad2Deg);

			GameObject instance = Instantiate(projectile, source.transform.position, rotation) as GameObject;
			instance.GetComponent<Rigidbody2D>().AddForce (force * speed);

			Destroy (instance, range);
		}
	}
}