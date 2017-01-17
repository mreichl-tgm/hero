using UnityEngine;

namespace Util {
	public class ClosestGameObjectWithTag : Navigable
	{
		[SerializeField]
		private string _targetTag;

		public override Vector3 Position {
			get {
				GameObject target = Util.ClosestGameObjectWithTag(gameObject, _targetTag);
			    return new Vector3 (target.transform.position.x, target.transform.position.y, 0);
			}
		}
	}
}