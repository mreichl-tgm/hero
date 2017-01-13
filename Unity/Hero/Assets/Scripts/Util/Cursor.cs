﻿namespace Assets.Scripts.Util {
	public class Cursor : Navigable {

		public override Vector3 position {
			get {
				Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				return new Vector3(mousePosition.x, mousePosition.y, 0);
			}
		}
	}
}