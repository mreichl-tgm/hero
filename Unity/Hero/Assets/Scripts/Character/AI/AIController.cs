using Assets.Scripts.Effect.ActivatableEffect;

namespace Assets.Scripts.Character.AI
{
    public class AIController : MonoBehaviour {
	
        private Attack attack;

        void Awake() {
            attack = GetComponent<Attack>();
        }

        void FixedUpdate() {
            attack.Activate();
        }
    }
}
