using System;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace TGPAssignment
{
	public class LevelOne : Scene
	{
		Player p;
		Background one;
		Obstacle vehicle;
		Background exit;
		public LevelOne ()
		{
			this.RegisterDisposeOnExitRecursive();
			Scheduler.Instance.ScheduleUpdateForTarget(this, 1, false);
			
			
			
			p = new Player();
			one = new Background();
			vehicle = new Obstacle();
			exit = new Background();
			
			this.AddChild(one.spriteOne);
			this.AddChild(p.sprite);
			this.AddChild(vehicle.spriteObstacleOne);
			this.AddChild(exit.exitSprite);

			
		}
		
		public override void Update (float dt)
		{				
				one.Update();
				p.Update();
				vehicle.Update();
				exit.Update();
				base.Update (dt);
			

			
		}
	}
}

