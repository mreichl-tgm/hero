using UnityEngine;

namespace Util {
	public abstract class Navigable : MonoBehaviour
	{
		public abstract Vector3 Position { get; }
	}
}