using System;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Input;
namespace TGPAssignment
{
	public class Menu : Scene
	{
		MenuScreen m;
		public Menu ()
		{
			this.RegisterDisposeOnExitRecursive();
			Scheduler.Instance.ScheduleUpdateForTarget(this, 1, false);
			m = new MenuScreen();
			this.AddChild(m.start);
			m.start.Position = new Vector2(-14.0f, -8.0f);
			m.start.Scale = new Vector2(28.0f, 16.0f);
			
		}
		
		public override void Update (float dt)
		{
			var touches = Touch.GetData(0);
			if(touches.Count > 0)
			{
				Director.Instance.ReplaceScene(new LevelOne());
			}
		}
	}
}

