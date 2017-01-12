using UnityEngine;
using System.Collections;

namespace Hero.Util {
	public class ClosestGameObjectWithTag : Navigable{
		[SerializeField]
		private string targetTag;

		public override Vector3 position {
			get {
				GameObject target = Util.ClosestGameObjectWithTag(this.gameObject, targetTag);
				return new Vector3 (target.transform.position.x, target.transform.position.y, 0);
			}
		}
	}
}