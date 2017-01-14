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

        private double _nextShot;

        public override void Activate() {
            if (Time.time > _nextShot - transform.root.GetComponent<Attributes>().Agility * 0.001) {
                _nextShot = Time.time + _rate * 0.01;

                Vector3 force = (_target.Position - transform.position).normalized;

                Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Atan2(force.y, force.x) * Mathf.Rad2Deg);

                GameObject instance = Instantiate(_projectile, transform.position, rotation) as GameObject;

                if (instance != null)
                {
                    instance.GetComponent<Rigidbody2D>().AddForce (force * _speed);
                    Destroy (instance, _range * 0.1F);
                }
            }
        }
    }
}