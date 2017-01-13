using UnityEngine;

namespace Character.Ai
{
    public class AiMovement : MonoBehaviour {
	
        private Rigidbody2D _rb2D;
        private GameObject _target;

        void Awake() {
            _rb2D = GetComponent<Rigidbody2D>();
        }

        void FixedUpdate () {
            _target = Util.Util.ClosestGameObjectWithTag(this.gameObject, "Player");

            Vector3 force = (_target.transform.position - transform.position).normalized;
            _rb2D.velocity = new Vector2(force.x, force.y) * GetComponent<Attributes>().Speed;
        }
    }
}
