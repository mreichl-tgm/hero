using Attributes;
using UnityEngine;
using Util;

namespace Effects.ActivatableEffects
{
    public class Attack : ActivatableEffect
    {
        [SerializeField] private GameObject _projectile;
        [SerializeField] private float _range;
        [SerializeField] private float _rate;
        [SerializeField] private float _speed;
        [SerializeField] private Navigable _target;
        [SerializeField] private Attribute _agility;

        private double _nextShot;

        public override void Activate() {
            if (Time.time < _nextShot - _agility.Value * 0.001) return;

            _nextShot = Time.time + _rate * 0.01;

            var force = (_target.Position - transform.position).normalized;

            var rotation = Quaternion.Euler(0, 0, Mathf.Atan2(force.y, force.x) * Mathf.Rad2Deg);

            var instance = Instantiate(_projectile, transform.position, rotation) as GameObject;

            if (instance == null) return;

            instance.transform.parent = transform;
            instance.GetComponent<Rigidbody2D>().velocity = force * _speed;

            Destroy (instance, _range * 0.1F);
        }
    }
}