using UnityEngine;

namespace Hero.Util {
	public static class Util {	
		public static GameObject ClosestGameObjectWithTag(GameObject source, string tag) {
			GameObject[] targets = GameObject.FindGameObjectsWithTag(tag);
			GameObject closest = null;

			float closestDistance = Mathf.Infinity;

			foreach (GameObject target in targets) {
				float distance = Vector3.Distance(target.transform.position, source.transform.position);

				if (distance < closestDistance) {
					closest = target;
					closestDistance = distance;
				}
			}

			return closest;
		}
	}
}