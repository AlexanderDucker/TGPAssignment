using System;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;
using Sce.PlayStation.Core;

namespace TGPAssignment
{
	public class LevelTwo : Scene
	{
		Player p;
		Background two;
		private Vector2 spawnPoint;
		
		public LevelTwo ()
		{
			this.RegisterDisposeOnExitRecursive();
			Scheduler.Instance.ScheduleUpdateForTarget(this, 1, false);
			spawnPoint = new Vector2(-14.0f, -7.0f);
			
			
			p = new Player(spawnPoint);
			two = new Background();
			
			this.AddChild(two.spriteOne);
			this.AddChild(p.sprite);

			
		}
		
		public override void Update (float dt)
		{				
			two.Update();
			p.Update();
			base.Update (dt);
			
		}
	}
}

