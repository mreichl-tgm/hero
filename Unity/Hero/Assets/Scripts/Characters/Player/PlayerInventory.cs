using Effect.ActivatableEffect;
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

        [SerializeField]
        private KeyCode _input;

        void FixedUpdate()
        {
            if (Input.GetKey(_input))
            {
                foreach (ItemSlot i in _equipment)
                {
                    i.Item.GetComponent<ActivatableEffect>().Activate();
                }
            }
        }
    }
}