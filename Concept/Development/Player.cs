using System.Collections;
using UnityEngine;

public class Player : Moveable, IAlive
{
    public int health { get; set; }

    void Update ()
    {
		//UP
		if (Input.GetKey (KeyCode.W))
			MoveUp (); 		    //constant velocity, not accelerating
		if (Input.GetKeyUp (KeyCode.W))
            Stop();             //stops movement when key is released

        //DOWN
        if (Input.GetKey (KeyCode.S))
			MoveDown (); 		//constant velocity, not accelerating
		if (Input.GetKeyUp (KeyCode.S))
			Stop(); 			//stops movement when key is released

		//LEFT
		if (Input.GetKey (KeyCode.A))
			MoveLeft ();        //constant velocity, not accelerating
        if (Input.GetKeyUp(KeyCode.A))
            Stop(); 			//stops movement when key is released

		//RIGHT
		if (Input.GetKey (KeyCode.D))
			MoveRight ();       //constant velocity, not accelerating
        if (Input.GetKeyUp(KeyCode.D))
            Stop();             //stops movement when key is released

        //UPRIGHT
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            MoveUpRight();      //To move in 2 directions simultanously, not the opposite direction

		//UPLEFT
		if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.A))
			MoveUpLeft();		//To move in 2 directions simultanously, not the opposite direction

		//DOWNLEFT
		if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.S))
			MoveDownLeft();		//To move in 2 directions simultanously, not the opposite direction

		//DOWNRIGHT
		if (Input.GetKey (KeyCode.S) && Input.GetKey (KeyCode.D))
			MoveDownRight();	//To move in 2 directions simultanously, not the opposite direction
	}
}
