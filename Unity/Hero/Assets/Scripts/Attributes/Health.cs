using UnityEngine;

namespace Attributes
{
    public class Health : Attribute
    {
        [SerializeField]
        private int _min;
        [SerializeField]
        private int _max;
    }
}