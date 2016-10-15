using UnityEngine;
using System.Collections;

public class Moveable : MonoBehaviour {

	//initialise 2-Dimensional coordinates with Vector2 (float x, float y)
	private Vector2 upleft;
	private Vector2 upright;
	private Vector2 downleft;
	private Vector2 downright;
    private Vector2 stop;

    private Rigidbody2D rb2D;

	public float speed;

	public Moveable() {
		upleft = new Vector2(-1f, 1f);
		upright = new Vector2 (1f, 1f);
		downleft = new Vector2 (-1f, -1f);
		downright = new Vector2 (1f, -1f);
        stop = new Vector2(0f, 0f);
    }

    public void Awake() {
        this.rb2D = GetComponent<Rigidbody2D>();
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
	protected void MoveUpLeft () {
		rb2D.velocity = upleft * speed;
	}

	//UPRIGHT
	protected void MoveUpRight () {
		rb2D.velocity = upright * speed;
	}

	//DOWNLEFT
	protected void MoveDownLeft () {
		rb2D.velocity = downleft * speed;
	}

	//DOWNRIGHT
	protected void MoveDownRight () {
		rb2D.velocity = downright * speed;
	}

    //STOP
    protected void Stop() {
        rb2D.velocity = stop;
    }
}