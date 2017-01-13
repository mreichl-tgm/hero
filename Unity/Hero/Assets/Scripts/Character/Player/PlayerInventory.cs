using Item;
using UnityEngine;

namespace Character.Player
{
    public class PlayerInventory : Inventory
    {
        [SerializeField]
        private ItemSlot[] _baseItems;
        [SerializeField]
        private ItemSlot[] _equipment;
    }
}