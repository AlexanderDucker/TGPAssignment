using System;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace TGPAssignment
{
	public class LevelThree : Scene
	{
		
		public LevelThree ()
		{
			this.RegisterDisposeOnExitRecursive();
			Scheduler.Instance.ScheduleUpdateForTarget(this, 1, false);
			
			
			
			Player p = new Player();
			Background three = new Background();
			
			this.AddChild(three.spriteThree);
			this.AddChild(p.sprite);
			three.Update();
			p.Update();
			
		}
	}
}

