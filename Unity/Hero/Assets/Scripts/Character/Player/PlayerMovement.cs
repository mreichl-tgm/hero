using UnityEngine;

namespace Character.Player
{
    [RequireComponent(typeof(Attributes))]
    public class PlayerMovement : Movement
    {
        void FixedUpdate() {
            Rb2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * GetComponent<Attributes>().Speed;
        }
    }
}