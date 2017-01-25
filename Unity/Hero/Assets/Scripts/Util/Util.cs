using UnityEngine;

namespace Util {
	public static class Util {
		public static GameObject ClosestGameObjectWithTag(GameObject source, string tag)
		{
			var targets = GameObject.FindGameObjectsWithTag(tag);
			GameObject closest = null;

			var closestDistance = Mathf.Infinity;

			foreach (var target in targets) {
				var distance = Vector3.Distance(target.transform.position, source.transform.position);

			    if (distance > closestDistance)
			        continue;

			    closest = target;
			    closestDistance = distance;
			}

			return closest;
		}
	}
}