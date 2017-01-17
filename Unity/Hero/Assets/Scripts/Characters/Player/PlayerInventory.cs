using Effects.ActivatableEffects;
using Items;
using UnityEngine;

namespace Characters.Player
{
    public class PlayerInventory : Inventory
    {
        [SerializeField] private ItemSlot[] _baseItems;
        [SerializeField] private EquipmentSlot[] _equipment;

        private void FixedUpdate()
        {
            foreach (EquipmentSlot es in _equipment)
            {
                if (Input.GetButton("Fire1"))
                    es.Item.GetComponent<ActivatableEffect>().Activate();
            }
        }

        [System.Serializable]
        private class EquipmentSlot : ItemSlot
        {
            [SerializeField]
            public string Button;
        }
    }
}
