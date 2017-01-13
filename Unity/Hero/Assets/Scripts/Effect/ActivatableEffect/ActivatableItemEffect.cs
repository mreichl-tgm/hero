using UnityEngine;

namespace Effect.ActivatableEffect
{
    public class ActivatableItemEffect : Effect
    {
        [SerializeField]
        private KeyCode _trigger;
        [SerializeField]
        private ActivatableEffect _effect;

        void FixedUpdate() {
            if (Input.GetKey(_trigger)) {
                _effect.Activate();
            }
        }
    }
}