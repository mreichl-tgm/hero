using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed;

	[SerializeField]
	private float Test{ get; set; }

	[SerializeField]
	private Rigidbody2D rb2D;

	private float moveHorizontal;
	private float moveVertical;


	void Awake() {
		rb2D = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate() {
		
		moveHorizontal = Input.GetAxisRaw ("Horizontal"); //Horizontal movement up and down
		moveVertical = Input.GetAxisRaw ("Vertical"); //Vertical movement left and right

		rb2D.velocity = new Vector2 (moveHorizontal, moveVertical) * speed; //velocity for linear movement
	}

//	void Update () {
//		
//		//UP
//		if (Input.GetKey (KeyCode.W))
//			MoveUp (); 		//constant velocity, not accelerating
//		if (Input.GetKeyUp (KeyCode.W))
//			rb2D.velocity = stop; 			   		//stops movement when key is released
//
//		//DOWN
//		if (Input.GetKey (KeyCode.S))
//			MoveDown (); 		//constant velocity, not accelerating
//		if (Input.GetKeyUp (KeyCode.S))
//			rb2D.velocity = stop; 					//stops movement when key is released
//
//		//LEFT
//		if (Input.GetKey (KeyCode.A))
//			MoveLeft (); 		//constant velocity, not accelerating
//		if (Input.GetKeyUp (KeyCode.A))
//			rb2D.velocity = stop; 					//stops movement when key is released
//
//		//RIGHT
//		if (Input.GetKey (KeyCode.D))
//			MoveRight (); 		//constant velocity, not accelerating
//		if (Input.GetKeyUp (KeyCode.D))
//			rb2D.velocity = stop; 					//stops movement when key is released
//
//
//		//UPRIGHT
//		if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.D))
//			MoveUpRight (this.rb2D, this.speed);					//To move in 2 directions simultanously, not the opposite direction
//
//		//UPLEFT
//		if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.A))
//			MoveUpLeft (this.rb2D, this.speed);						//To move in 2 directions simultanously, not the opposite direction
//
//		//DOWNLEFT
//		if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.S))
//			MoveDownLeft (this.rb2D, this.speed);					//To move in 2 directions simultanously, not the opposite direction
//
//		//DOWNRIGHT
//		if (Input.GetKey (KeyCode.S) && Input.GetKey (KeyCode.D))
//			MoveDownRight (this.rb2D, this.speed);					//To move in 2 directions simultanously, not the opposite direction
//	}
}
