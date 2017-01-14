using UnityEngine;

namespace Attributes
{
    public class Attribute : MonoBehaviour
    {
        [SerializeField]
        private int _min;
        [SerializeField]
        private int _max;
        [SerializeField]
        private int _value;
        public int Value
        {
            get { return _value; }
            set { _value = Mathf.Clamp(value, _min, _max); }
        }
    }
}