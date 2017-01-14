using Effects.ActivatableEffects;
using UnityEngine;

namespace Characters.Ai
{
    [RequireComponent(typeof(AiModel))]
    public class AiController : MonoBehaviour
    {
        private AiModel _model;
        private Attack[] _attacks;

        void Awake() {
            _attacks = GetComponents<Attack>();
        }

        void FixedUpdate() {
            foreach (Attack attack in _attacks)
            {
                attack.Activate();
            }
        }
    }
}
