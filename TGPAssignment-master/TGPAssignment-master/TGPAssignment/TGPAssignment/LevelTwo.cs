using System;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace TGPAssignment
{
	public class LevelTwo : Scene
	{
		Player p;
		Background two;
		
		public LevelTwo ()
		{
			this.RegisterDisposeOnExitRecursive();
			Scheduler.Instance.ScheduleUpdateForTarget(this, 1, false);
			
			
			
			p = new Player();
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

