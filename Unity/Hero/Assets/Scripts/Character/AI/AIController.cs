using UnityEngine;

public class AIController : MonoBehaviour {
	private Attack attack;

	void Awake() {
		attack = GetComponent<Attack>();
	}

	void Start() {
		attack.Activate();
	}
}
