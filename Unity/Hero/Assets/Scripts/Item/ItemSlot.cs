using System;
using UnityEngine;

namespace Item
{
    [Serializable]
    public class ItemSlot
    {
        [SerializeField]
        private GameObject _item;
        [SerializeField]
        private ItemType _type;
    }
}
