using UnityEngine;
using Attributes;

namespace Characters.Ai
{
    public class AiMovement : Movement
    {
        [SerializeField] private string _targetTag;
        [SerializeField] private Attribute _speed;

        private GameObject _target;

        private void FixedUpdate () {
            _target = Util.Util.ClosestGameObjectWithTag(gameObject, _targetTag);

            if (_target == null) return;

            var force = (_target.transform.position - transform.position).normalized;

            Rb2D.velocity = new Vector2(force.x, force.y) * _speed.Value;
        }
    }
}
