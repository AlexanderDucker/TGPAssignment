using System;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;
using Sce.PlayStation.Core;

namespace TGPAssignment
{
	public class LevelOne : Scene
	{
		Player p;
		Background one;
		Background exit;
		Obstacle[] branch;
		private Vector2 spawnPoint;
		private Vector2[] branchPosition;
		private int branchNumber;
		public bool hasCollided;
		public bool levelComplete;
		public Timer timer;
		public float prevTime;
		public float currentTime;
		public float elapsedTime;
		public float timeInSeconds;
		
		public LevelOne ()
		{
			this.RegisterDisposeOnExitRecursive();
			Scheduler.Instance.ScheduleUpdateForTarget(this, 1, false);
			spawnPoint = new Vector2(-14.0f, -8.0f);
			branchNumber = 8;
			branchPosition = new Vector2[branchNumber];
			branch = new Obstacle[branchNumber];
			one = new Background();
			exit = new Background();
			hasCollided = false;
			levelComplete = false;
			timer = new Timer();
			prevTime = (float)timer.Milliseconds();
			branchPosition[0] = new Vector2(-14.0f, -6.2f);
			branchPosition[1] = new Vector2(-10.2f, -4.2f);
			branchPosition[2] = new Vector2(-15.2f, -0.5f);
			branchPosition[3] = new Vector2(-6.6f, -2.15f);
			branchPosition[4] = new Vector2(-6.6f, -6.2f);
			branchPosition[5] = new Vector2(-0.6f, -2.3f);
			branchPosition[6] = new Vector2(4.7f, -3.1f);
			branchPosition[7] = new Vector2(8.8f, -1.0f);
			
			for(int i = 0; i < branchNumber; i++)
				branch[i] = new Obstacle(branchPosition[i]);
			p = new Player(spawnPoint);

			
			this.AddChild(one.spriteOne);
			this.AddChild(exit.exitSprite);
			for(int i = 0; i < branchNumber; i++)
				this.AddChild(branch[i].branchSprite);
			this.AddChild(p.sprite);
			
		}
		
		public override void Update (float dt)
		{				
			one.Update();
			p.Update();
			exit.Update();
			base.Update (dt);
			CollisionCheck();
			currentTime = (float)timer.Milliseconds();
			elapsedTime = currentTime - prevTime;
			prevTime = currentTime;
			timeInSeconds = (elapsedTime / 60);
			if(levelComplete)
			{
				Director.Instance.ReplaceScene(new EndScreen(timeInSeconds));
			}
			
		}
		
		public void CollisionCheck()
		{
			for(int i = 0; i < branchNumber; i++)
			{
				branch[i].branchSprite.GetContentWorldBounds(ref branch[i].bounds);
				exit.exitSprite.GetContentWorldBounds(ref exit.bounds);
				p.sprite.GetContentWorldBounds(ref p.bounds);
				if(p.velocity.Y <= 0.0f)
				{
					if(p.bounds.Overlaps(branch[i].bounds))
					{
						p.sprite.Position = new Vector2(p.sprite.Position.X, branchPosition[i].Y + 0.8f);
						p.hasJumped = false;
						p.isOnGround = true;
						hasCollided = true;
					}
					
					else if(!p.bounds.Overlaps(branch[i].bounds) && p.velocity.Y == 0)
						p.hasJumped = true;

					   
				}
				if(p.bounds.Overlaps(exit.bounds))
					levelComplete = true;
				
			}
		}
		

	}
}

