using System;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace TGPAssignment
{
	public class LevelOne : Scene
	{
		
		public LevelOne ()
		{
			this.RegisterDisposeOnExitRecursive();
			Scheduler.Instance.ScheduleUpdateForTarget(this, 1, false);
			
			
			
			Player p = new Player();
			Background one = new Background();
			
			this.AddChild(one.spriteOne);
			this.AddChild(p.sprite);
			one.Update();
			p.Update();
			
		}
	}
}

