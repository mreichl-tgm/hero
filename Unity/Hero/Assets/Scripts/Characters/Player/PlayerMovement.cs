using Attributes;
using UnityEngine;

namespace Characters.Player
{
    [RequireComponent(typeof(Speed))]
    public class PlayerMovement : Movement
    {
        private void FixedUpdate() {
            Rb2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * GetComponent<Speed>().Value;
        }
    }
}