using Attributes;
using UnityEngine;

namespace Characters.Player
{
    [RequireComponent(typeof(PlayerModel))]
    [RequireComponent(typeof(PlayerInventory))]
    public class PlayerController : MonoBehaviour, IAlive
    {
        [SerializeField] private Attribute _health;

        private PlayerModel _model;
        private PlayerInventory _inventory;

        private void Awake()
        {
            _model = GetComponent<PlayerModel>();
            _inventory = GetComponent<PlayerInventory>();
        }

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
