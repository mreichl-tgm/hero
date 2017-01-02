using UnityEngine;

public class AIController : MonoBehaviour {
	private AIModel model;
	private ActivatableEffect[] attacks;

	void Awake() {
		model = GetComponent<AIModel>();
		attacks = GetComponents<Attack>();

		foreach (Attack a in attacks) {
			a.Activate();
		}
	}
}
