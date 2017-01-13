using Effect.ActivatableEffect;
using UnityEngine;

namespace Character.Ai
{
    public class AiController : MonoBehaviour {
	
        private Attack _attack;

        void Awake() {
            _attack = GetComponent<Attack>();
        }

        void FixedUpdate() {
            _attack.Activate();
        }
    }
}
