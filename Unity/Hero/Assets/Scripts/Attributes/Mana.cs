using UnityEngine;

namespace Attributes
{
    public class Mana : Attribute
    {
        [SerializeField]
        private int _min;
        [SerializeField]
        private int _max;
    }
}