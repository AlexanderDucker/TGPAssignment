using System;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;
using Sce.PlayStation.Core;

namespace TGPAssignment
{
	public class LevelThree : Scene
	{
		Player p;
		Background three;
		private Vector2 spawnPoint;
		public LevelThree ()
		{
			this.Camera.SetViewFromViewport();
			this.RegisterDisposeOnExitRecursive();
			Scheduler.Instance.ScheduleUpdateForTarget(this, 1, false);
			spawnPoint = new Vector2(-14.0f, -7.0f);
			
			
			p = new Player(spawnPoint);
			three = new Background();
			
			this.AddChild(three.spriteThree);
			this.AddChild(p.sprite);
			
		}
		
		public override void Update (float dt)
		{				
				three.Update();
				p.Update();
				base.Update (dt);
			
		}		
	}
}

