using UnityEngine;
using Hero.Util;

public class AIController : MonoBehaviour {
	
	private Attack attack;

	void Awake() {
		attack = GetComponent<Attack>();
	}

	void FixedUpdate() {
		attack.Activate();
	}
}
