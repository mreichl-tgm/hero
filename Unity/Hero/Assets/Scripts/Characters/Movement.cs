using UnityEngine;

namespace Characters
{
    [RequireComponent (typeof(Rigidbody2D))]
    public class Movement : MonoBehaviour
    {
        protected Rigidbody2D Rb2D;

        private void Awake()
        {
            Rb2D = GetComponent<Rigidbody2D>();
        }
    }
}