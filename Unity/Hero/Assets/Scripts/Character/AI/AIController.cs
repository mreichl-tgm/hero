using UnityEngine;
using Hero.Util;

public class AIController : MonoBehaviour {
	
	private Attack attack;

	void Awake() {
		attack = GetComponent<Attack>();
	}

	void Start() {
		attack.target = Util.ClosestGameObjectWithTag(this.gameObject, "Player");
		attack.Activate();
	}
}
