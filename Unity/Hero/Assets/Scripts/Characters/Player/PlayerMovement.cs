using UnityEngine;

namespace Characters.Player
{
    [RequireComponent(typeof(Attributes.Attributes))]
    public class PlayerMovement : Movement
    {
        void FixedUpdate() {
            Rb2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * GetComponent<Attributes.Attributes>().Speed;
        }
    }
}