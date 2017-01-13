using UnityEngine;

namespace Character.Player
{
    public class PlayerMovement : MonoBehaviour {
	
        private Attributes _attributes;
        private Rigidbody2D _rb2D;

        private float _vHorizontal;
        private float _vVertical;

        void Awake() {
            _rb2D = GetComponent<Rigidbody2D>();
        }

        void FixedUpdate() {
            _vHorizontal = Input.GetAxisRaw("Horizontal");
            _vVertical = Input.GetAxisRaw("Vertical");

            _rb2D.velocity = new Vector2(_vHorizontal, _vVertical) * GetComponent<Attributes>().Speed;
        }
    }
}