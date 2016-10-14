using UnityEngine;
using System.Collections;

public class IsMoveable : MonoBehaviour {

	//initialise 2-Dimensional coordinates with Vector2 (float x, float y)
	private Vector2 upleft;
	private Vector2 upright;
	private Vector2 downleft;
	private Vector2 downright;

	private Rigidbody2D rb2D;
	private float speed;

	public IsMoveable(Rigidbody2D rb2D, float speed) {
		upleft = new Vector2(-1f, 1f);
		upright = new Vector2 (1f, 1f);
		downleft = new Vector2 (-1f, -1f);
		downright = new Vector2 (1f, -1f);

		this.rb2D = rb2D;
		this.rb2D = GetComponent<Rigidbody2D> ();

		this.speed = speed;
	}


	//UP
	public void MoveUp () {
		rb2D.velocity = Vector2.up * speed;
	}

	//DOWN
	protected void MoveDown () {
		rb2D.velocity = Vector2.down * speed;
	}

	//LEFT
	protected void MoveLeft () {
		rb2D.velocity = Vector2.left * speed;
	}

	//RIGHT
	protected void MoveRight () {
		rb2D.velocity = Vector2.right * speed;
	}

	//UPLEFT
	protected void MoveUpLeft (Rigidbody2D rb2D, float speed) {
		rb2D.velocity = upleft * speed;
	}

	//UPRIGHT
	protected void MoveUpRight (Rigidbody2D rb2D, float speed) {
		rb2D.velocity = upright * speed;
	}

	//DOWNLEFT
	protected void MoveDownLeft (Rigidbody2D rb2D, float speed) {
		rb2D.velocity = downleft * speed;
	}

	//DOWNRIGHT
	protected void MoveDownRight (Rigidbody2D rb2D, float speed) {
		rb2D.velocity = downright * speed;
	}
}
