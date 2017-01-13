using UnityEngine;
using Util;

namespace Effect.ActivatableEffect
{
    [RequireComponent(typeof(Attributes))]
    public class Attack : ActivatableEffect
    {
        [SerializeField]
        private GameObject _projectile;
        [SerializeField]
        private float _range;
        [SerializeField]
        private float _rate;
        [SerializeField]
        private float _speed;
        [SerializeField]
        private Navigable _target;

        private float _last;

        public override void Activate() {
            if (Time.time > _last + _rate / 100 - transform.root.GetComponent<Attributes>().Agility / 100) {
                _last = Time.time;

                Vector3 force = (_target.Position - transform.position).normalized;

                Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Atan2(force.y, force.x) * Mathf.Rad2Deg);

                GameObject instance = Instantiate(_projectile, transform.position, rotation) as GameObject;
                instance.GetComponent<Rigidbody2D>().AddForce (force * _speed);

                Destroy (instance, _range / 10);
            }
        }
    }
}