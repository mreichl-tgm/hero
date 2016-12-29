using UnityEngine;
using System.Collections;
using System.Timers;

public class Shoot : MonoBehaviour {

	public GameObject projectile;
	public Texture2D texture;

	public float fireRate;
	public float missileSpeed;

	private float nextFire;
	private float angle;
	private float radius;

	private GameObject player;
	private GameObject enemy;
	private Vector3 shootPos;

	void Awake() {
		player = GameObject.Find ("Player");
	}

	void Start() {
		missileSpeed *= 100;

		nextFire = 0f;
	
		Cursor.SetCursor (texture, new Vector2(25f, 25f), CursorMode.Auto);

		radius = shootPos.magnitude;

	}


	
	// Update is called once per frame
	void Update () {
		
		Vector2 currPos = Camera.main.WorldToScreenPoint(transform.position); //Current position relative to screen size
		Vector3 mousePos = new Vector3(Input.mousePosition.x - currPos.x, Input.mousePosition.y - currPos.y, 0).normalized;

		angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

		shootPos = (transform.position - mousePos * -1.5f);

		if (gameObject.activeInHierarchy && Input.GetMouseButton(0) && Time.time > nextFire) {

			nextFire = Time.time + fireRate;

//			transform.rotation = Quaternion.Euler(0, 0, angle);
			projectile.transform.rotation = Quaternion.Euler(0, 0, angle);

			Rigidbody2D projectile2D;
			projectile2D = Instantiate (projectile.GetComponent<Rigidbody2D>(), shootPos, projectile.transform.rotation) as Rigidbody2D;
			projectile2D.AddForce(mousePos * missileSpeed);
		}

//		if (Input.GetMouseButton(1) && Time.time > nextFire) {
//
//			nextFire = Time.time + fireRate;
//
//			projectile.transform.rotation = Quaternion.Euler(0, 0, angle);
//
//			Rigidbody2D projectile2D;
//			projectile2D = Instantiate (projectile, new Vector3(shootPos.x + radius * Mathf.Cos((30*360) * Mathf.Rad2Deg), shootPos.y + radius * Mathf.Sin((30*360) * Mathf.Rad2Deg), 0), projectile.transform.rotation) as Rigidbody2D;
//			projectile2D.AddForce(mousePos * missileSpeed);


//			Rigidbody2D projectile2D2;
//			projectile2D2 = Instantiate (projectile, new Vector3(shootPos.x + 1, shootPos.y + 1, 0), projectile.transform.rotation) as Rigidbody2D;
//			projectile2D2.AddForce(mousePos * missileSpeed);
//		}

	}
}