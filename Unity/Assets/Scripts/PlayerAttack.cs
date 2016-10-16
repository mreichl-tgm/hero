using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {
	public GameObject shot;
	public float range;
	public float fireRate;

	private Transform shotSpawn;
	private float nextFire;

	void Start()
	{
		shotSpawn = GetComponent<Transform> ();
	}

	void Update()
	{
		if (Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Destroy(Instantiate(shot, shotSpawn.position, shotSpawn.rotation), range);
		}
	}
}
