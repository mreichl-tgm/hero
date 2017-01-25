using Attributes;
using UnityEngine;

namespace Characters.Player
{
    public class PlayerMovement : Movement
    {
        [SerializeField] private Attribute _speed;

        private void FixedUpdate() {
            Rb2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * _speed.Value;
        }
    }
}