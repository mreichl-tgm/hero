using System;
using UnityEngine;

namespace Items
{
    [Serializable]
    public class ItemSlot
    {
        [SerializeField]
        private GameObject _item;
        public GameObject Item
        {
            get { return _item; }
            set
            {
                if (value.GetComponent<ItemModel>().Type == _type)
                    _item = value;
            }
        }

        [SerializeField]
        private ItemType _type;
    }
}
