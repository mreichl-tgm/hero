using UnityEngine;

namespace Attributes
{
    [System.Serializable]
    public class Attribute
    {
        [SerializeField] private int _min;
        [SerializeField] private int _max;
        [SerializeField] private int _value;

        public int Min { get { return _min; } }
        public int Max { get { return _max; } }
        public int Value
        {
            get { return _value; }
            set { _value = Mathf.Clamp(value, Min, _max); }
        }
    }
}