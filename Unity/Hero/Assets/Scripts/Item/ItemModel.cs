using UnityEngine;

namespace Item
{
    public class ItemModel : MonoBehaviour {
	
        [SerializeField]
        private ItemType _type;
        [SerializeField]
        private string _description;

        public int Damage;
    }
}