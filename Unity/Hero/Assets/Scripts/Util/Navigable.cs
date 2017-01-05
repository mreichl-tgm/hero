using UnityEngine;


namespace Hero.Util {
	public abstract class Navigable : MonoBehaviour {
		
		public abstract Vector3 position { get; }
	}
}