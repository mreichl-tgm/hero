using Attributes;
using UnityEngine;

namespace Characters.Player
{
    [RequireComponent(typeof(Attribute))]
    public class PlayerMovement : Movement
    {
        private void FixedUpdate() {
            Rb2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * GetComponent<Attribute>().Value;
        }
    }
}