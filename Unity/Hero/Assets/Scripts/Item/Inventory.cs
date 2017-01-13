using UnityEngine;

namespace Item
{
    public class Inventory : MonoBehaviour {

        [SerializeField]
        private ItemSlot[] _baseItems;
        [SerializeField]
        private GameObject[] _inventory;
        [SerializeField]
        private ItemSlot[] _equipment;
    }
}