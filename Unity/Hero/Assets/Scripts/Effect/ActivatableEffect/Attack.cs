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

	private float lastTime;
	private bool active;

	public override void Activate() {
		active = !active;
	}

	void Awake() {
		active = false;
	}

	void FixedUpdate() {
		if (active && Time.time > lastTime + (rate / 100 - source.GetComponent<Attributes>().agility / 100)) {
			lastTime = Time.time;

			Vector3 force = (target.transform.position - source.transform.position).normalized;

			Quaternion rotation = Quaternion.FromToRotation (source.transform.position, target.transform.position);

			GameObject instance = Instantiate (projectile, source.transform.position, rotation) as GameObject;
			instance.GetComponent<Rigidbody2D>().AddForce (force * speed);

			Destroy (instance, range);
		}
	}
}