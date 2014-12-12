using System;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace TGPAssignment
{
	public class LevelFour : Scene
	{
		Player p;
		Background four;
		public LevelFour ()
		{
			this.RegisterDisposeOnExitRecursive();
			Scheduler.Instance.ScheduleUpdateForTarget(this, 1, false);
			
			
			
			Player p = new Player();
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

