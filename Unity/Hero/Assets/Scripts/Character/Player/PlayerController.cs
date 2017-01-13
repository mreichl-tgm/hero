using Item;
using UnityEngine;

namespace Character.Player
{
    [RequireComponent(typeof(PlayerModel))]
    [RequireComponent(typeof(PlayerInventory))]
    public class PlayerController : MonoBehaviour
    {
        private PlayerModel _model;
        private Inventory _inventory;

        void Awake()
        {
            _model = GetComponent<PlayerModel>();
            _inventory = GetComponent<Inventory>();
        }
    }
}
