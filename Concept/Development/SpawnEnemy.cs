using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

	public GameObject enemy;

	private GameObject player;

	private float width;
	private float height;

	private Vector3 spawn;

	private float widthRange;
	private float heightRange;

	void Start () {
		width = Screen.width;
		height = Screen.height;

		player = GameObject.Find ("Player");

		InvokeRepeating ("SpawnEnemies", 1f, 2f);
	}

	void Update () {
		
		Debug.Log (spawn);
	}

	private void SpawnEnemies() {
		if (player != null && player.activeInHierarchy) {
			widthRange = Random.Range (0f, width);
			heightRange = Random.Range (0f, height);


			spawn = new Vector3 (widthRange, heightRange, 0f);
			spawn = Camera.main.ScreenToWorldPoint (spawn);
			spawn.z += 10;
			Instantiate (enemy, spawn, Quaternion.identity);
		}
	}
}
