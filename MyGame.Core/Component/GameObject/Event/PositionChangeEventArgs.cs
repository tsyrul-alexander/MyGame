﻿using Microsoft.Xna.Framework;

namespace MyGame.Core.Component.GameObject.Event {
	public class PositionChangeEventArgs : BaseControlEventArgs {
		public Vector2 OldValue { get; set; }
		public Vector2 NewValue { get; set; }
	}
}