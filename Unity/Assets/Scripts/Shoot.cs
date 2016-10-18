using UnityEngine;
using System.Collections;
using System.Timers;

public class Shoot : MonoBehaviour {

	public Rigidbody2D projectile;
	public Texture2D texture;

	public float fireRate;
	public float missileSpeed;

	private float nextFire;

	private GameObject player;

	void Awake() {
		player = GameObject.Find ("Player");
	}

	void Start() {
		missileSpeed *= 100;
		nextFire = 0f;
		Cursor.SetCursor (texture, new Vector2(25f, 25f), CursorMode.Auto);
	}


	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0) && Time.time > nextFire) {

			Vector2 currPos = Camera.main.WorldToScreenPoint(transform.position); //Current position relative to screen size
			Vector2 mousePos = new Vector2(Input.mousePosition.x - currPos.x, Input.mousePosition.y - currPos.y).normalized;

			nextFire = Time.time + fireRate;

			float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
//			transform.rotation = Quaternion.Euler(0, 0, angle);
			projectile.transform.rotation = Quaternion.Euler(0, 0, angle);

			Rigidbody2D projectile2D;
			projectile2D = Instantiate (projectile, player.transform.position, projectile.transform.rotation) as Rigidbody2D;
			projectile2D.AddForce(mousePos * missileSpeed);
		}
	}
}