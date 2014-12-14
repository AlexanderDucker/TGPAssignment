using System;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;
using Sce.PlayStation.Core;

namespace TGPAssignment
{
	public class LevelFour : Scene
	{
		Player p;
		Background four;
		private Vector2 spawnPoint;
		
		public LevelFour (bool nextLevel)
		{
			this.RegisterDisposeOnExitRecursive();
			Scheduler.Instance.ScheduleUpdateForTarget(this, 1, false);
			spawnPoint = new Vector2(-14.0f, -7.0f);
			
			
			Player p = new Player(spawnPoint);
			Background four = new Background();
			
			this.AddChild(four.spriteFour);
			this.AddChild(p.sprite);
			
		}
		
		public override void Update (float dt)
		{				
				four.Update();
				p.Update();
				base.Update (dt);
			
		}		
	}
}

