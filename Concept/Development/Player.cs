using UnityEngine;
using System.Collections;

public class Player : IsMoveable {

	public float speed;

	private Rigidbody2D rb2D;
	private Vector2 stop;

	public Player(Rigidbody2D rb2D, float speed) : base(rb2D,speed) {
	}

	void Awake() {
		rb2D = GetComponent<Rigidbody2D> ();

		stop = new Vector2 (0f, 0f);
	}

	void Update () {
		
		//UP
		if (Input.GetKey (KeyCode.W))
			MoveUp (); 		//constant velocity, not accelerating
		if (Input.GetKeyUp (KeyCode.W))
			rb2D.velocity = stop; 			   		//stops movement when key is released

		//DOWN
		if (Input.GetKey (KeyCode.S))
			MoveDown (); 		//constant velocity, not accelerating
		if (Input.GetKeyUp (KeyCode.S))
			rb2D.velocity = stop; 					//stops movement when key is released

		//LEFT
		if (Input.GetKey (KeyCode.A))
			MoveLeft (); 		//constant velocity, not accelerating
		if (Input.GetKeyUp (KeyCode.A))
			rb2D.velocity = stop; 					//stops movement when key is released

		//RIGHT
		if (Input.GetKey (KeyCode.D))
			MoveRight (); 		//constant velocity, not accelerating
		if (Input.GetKeyUp (KeyCode.D))
			rb2D.velocity = stop; 					//stops movement when key is released


		//UPRIGHT
		if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.D))
			MoveUpRight (this.rb2D, this.speed);					//To move in 2 directions simultanously, not the opposite direction

		//UPLEFT
		if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.A))
			MoveUpLeft (this.rb2D, this.speed);						//To move in 2 directions simultanously, not the opposite direction

		//DOWNLEFT
		if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.S))
			MoveDownLeft (this.rb2D, this.speed);					//To move in 2 directions simultanously, not the opposite direction

		//DOWNRIGHT
		if (Input.GetKey (KeyCode.S) && Input.GetKey (KeyCode.D))
			MoveDownRight (this.rb2D, this.speed);					//To move in 2 directions simultanously, not the opposite direction
	}
}
