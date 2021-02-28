﻿using GameEngineTK.Engine.Prototypes.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngineTK.Engine
{
	public class Physics : IComponentManager
	{
		public Vector2 Velocity = new Vector2();
		public Vector2 Acceleration = new Vector2();
		public bool isEnabled = false;

		public Vector2 Position { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public void Update()
		{
			this.Position += this.Velocity;
		}
	}
}
