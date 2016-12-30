using UnityEngine;

public class ActivatedItemEffect : ItemEffect {
	[SerializeField]
	private KeyCode trigger;
	[SerializeField]
	private ActivatableEffect target;

	void FixedUpdate() {
		if (Input.GetKeyDown(trigger)) {
			target.Activate();
		}
	}
}