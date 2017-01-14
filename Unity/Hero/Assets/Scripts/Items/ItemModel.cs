using UnityEngine;

namespace Items
{
    public class ItemModel : MonoBehaviour
    {
        [SerializeField]
        public readonly ItemType Type;

        [SerializeField]
        private string _description;

        public int Damage;
    }
}