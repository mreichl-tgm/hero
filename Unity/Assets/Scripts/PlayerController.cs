using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody2D rb2d;
	private Vector2 moveDirection;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() 
	{
		moveDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		rb2d.velocity = moveDirection * speed;
	}
}