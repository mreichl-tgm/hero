using Attributes;
using UnityEngine;

namespace Characters.Player
{
    public class PlayerController : MonoBehaviour, IAlive
    {
        [SerializeField] private Attribute _health;

        public void GetDamage(int damage)
        {
            _health.Value -= damage;

            if (_health.Value < _health.Min)
                Die();
        }

        public void Die()
        {
            throw new System.NotImplementedException();
        }
    }
}