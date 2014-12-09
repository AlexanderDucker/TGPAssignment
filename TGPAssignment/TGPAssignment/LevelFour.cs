using System;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace TGPAssignment
{
	public class LevelFour : Scene
	{
		
		public LevelFour ()
		{
			this.RegisterDisposeOnExitRecursive();
			Scheduler.Instance.ScheduleUpdateForTarget(this, 1, false);
			
			
			
			Player p = new Player();
			Background four = new Background();
			
			this.AddChild(four.spriteFour);
			this.AddChild(p.sprite);
			four.Update();
			p.Update();
			
		}
	}
}

