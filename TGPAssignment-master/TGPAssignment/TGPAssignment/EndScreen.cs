using System;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;
using Sce.PlayStation.HighLevel.UI;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Graphics;

namespace TGPAssignment
{
	public class EndScreen : Sce.PlayStation.HighLevel.GameEngine2D.Scene
	{
		MenuScreen m;
		public float currentTime, bestTime;
		public Sce.PlayStation.HighLevel.UI.Label timeLabel;
		public bool reset;
		public float totalTime;
		
		public EndScreen (float totalTime)
		{
			this.RegisterDisposeOnExitRecursive();
			Scheduler.Instance.ScheduleUpdateForTarget(this, 1, false);
			this.totalTime = totalTime;
			timeLabel = new Sce.PlayStation.HighLevel.UI.Label();
			string time = totalTime.ToString();
			timeLabel.Text = time;
			reset = false;

			m = new MenuScreen();
			this.AddChild(m.end);
			m.end.Position = new Vector2(-14.0f, -8.0f);
			m.end.Scale = new Vector2(28.0f, 16.0f);
		}
		
		public override void Update (float dt)
		{
			var gamePadData = GamePad.GetData(0);
			if((gamePadData.Buttons & GamePadButtons.Start) != 0)
				Director.Instance.ReplaceScene(new LevelOne());

		}
	}
}

