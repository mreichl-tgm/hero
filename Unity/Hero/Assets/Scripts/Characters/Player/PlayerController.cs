using UnityEngine;

namespace Characters.Player
{
    [RequireComponent(typeof(PlayerModel))]
    [RequireComponent(typeof(PlayerInventory))]
    public class PlayerController : MonoBehaviour
    {
        private PlayerModel _model;
        private PlayerInventory _inventory;

        void Awake()
        {
            _model = GetComponent<PlayerModel>();
            _inventory = GetComponent<PlayerInventory>();
        }
    }
}
