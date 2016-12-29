using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {

	public Rigidbody2D projectile;

	public float fireRate;
	public float missileSpeed;

	private float angle;
	private float nextFire;

	private GameObject player;
	private Vector3 shootPos;
	private Vector3 playerPosRel;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");

		missileSpeed *= 100;

		nextFire = 0f;
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 currPos = Camera.main.WorldToScreenPoint(transform.position); //Current position relative to screen size
		if (player != null)
			playerPosRel = Camera.main.WorldToScreenPoint (player.transform.position);
		
		Vector3 playerPos = new Vector3 (playerPosRel.x - currPos.x, playerPosRel.y - currPos.y, 0).normalized;

		angle = Mathf.Atan2(playerPos.y, playerPos.x) * Mathf.Rad2Deg;

		shootPos = (transform.position - playerPos * -1.5f);


		if (Time.time > nextFire) {

			nextFire = Time.time + fireRate;
	
			projectile.transform.rotation = Quaternion.Euler(0, 0, angle);

			Rigidbody2D projectile2D;
			projectile2D = Instantiate (projectile, shootPos, projectile.transform.rotation) as Rigidbody2D;
			projectile2D.AddForce (playerPos * missileSpeed);
		}
	}
}
