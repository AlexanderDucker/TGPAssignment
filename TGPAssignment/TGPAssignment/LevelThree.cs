using System;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace TGPAssignment
{
	public class LevelThree : Scene
	{
		Player p;
		Background three;
		public LevelThree ()
		{
			this.RegisterDisposeOnExitRecursive();
			Scheduler.Instance.ScheduleUpdateForTarget(this, 1, false);
			
			
			
			p = new Player();
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

