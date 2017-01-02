using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	
	private Rigidbody2D rb2D;
	private Attributes attributes;

	private float vHorizontal;
	private float vVertical;

	void Awake() {
		rb2D = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() {
		vHorizontal = Input.GetAxisRaw("Horizontal");
		vVertical = Input.GetAxisRaw("Vertical");

		rb2D.velocity = new Vector2(vHorizontal, vVertical) * GetComponent<Attributes>().speed;
	}
}