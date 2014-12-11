using System;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace TGPAssignment
{
	public class LevelOne : Scene
	{
		Player p;
		Background one;
		public LevelOne ()
		{
			this.RegisterDisposeOnExitRecursive();
			Scheduler.Instance.ScheduleUpdateForTarget(this, 1, false);
			
			
			
			 p = new Player();
			 one = new Background();
			
			this.AddChild(one.spriteOne);
			this.AddChild(p.sprite);

			
		}
		
		public override void Update (float dt)
		{				
				one.Update();
				p.Update();
				base.Update (dt);
			
		}
	}
}

