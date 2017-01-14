using UnityEngine;
using Attributes;

namespace Characters.Ai
{
    [RequireComponent(typeof(Attribute))]
    public class AiMovement : Movement
    {
        [SerializeField]
        private string _targetTag;

        private GameObject _target;

        private void FixedUpdate () {
            _target = Util.Util.ClosestGameObjectWithTag(gameObject, _targetTag);

            Vector3 force = (_target.transform.position - transform.position).normalized;

            Rb2D.velocity = new Vector2(force.x, force.y) * GetComponent<Attribute>().Value;
        }
    }
}
