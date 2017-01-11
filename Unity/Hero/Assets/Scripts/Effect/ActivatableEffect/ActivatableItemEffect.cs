using UnityEngine;

public class ActivatableItemEffect : Effect {
	
	[SerializeField]
	private KeyCode trigger;
	[SerializeField]
	private ActivatableEffect effect;

	void FixedUpdate() {
		if (Input.GetKey(trigger)) {
			effect.Activate();
		}
	}
}