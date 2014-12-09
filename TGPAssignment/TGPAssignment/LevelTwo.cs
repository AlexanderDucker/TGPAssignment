using System;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace TGPAssignment
{
	public class LevelTwo : Scene
	{
		
		public LevelTwo ()
		{
			this.RegisterDisposeOnExitRecursive();
			Scheduler.Instance.ScheduleUpdateForTarget(this, 1, false);
			
			
			
			Player p = new Player();
			Background two = new Background();
			
			this.AddChild(two.spriteOne);
			this.AddChild(p.sprite);
			two.Update();
			p.Update();
			
		}
	}
}

