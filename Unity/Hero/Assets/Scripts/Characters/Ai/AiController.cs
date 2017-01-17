using Effects.ActivatableEffects;
using UnityEngine;

namespace Characters.Ai
{
    [RequireComponent(typeof(AiModel))]
    public class AiController : MonoBehaviour
    {
        private AiModel _model;
        private Attack[] _attacks;

        private void Awake() {
            _attacks = GetComponents<Attack>();
        }

        public void FixedUpdate() {
            foreach (Attack attack in _attacks)
            {
                attack.Activate();
            }
        }
    }
}
