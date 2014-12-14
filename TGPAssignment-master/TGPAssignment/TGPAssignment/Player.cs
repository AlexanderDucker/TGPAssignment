using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;

using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;
using Sce.PlayStation.Core.Input;


namespace TGPAssignment
{
	public class Player
	{
		public			 SpriteUV 	sprite;
		private static TextureInfo	textureInfo;
		private static bool 		alive;
		public Vector2				velocity;
		public bool					hasJumped;
		public bool				isOnGround;
		public Bounds2 bounds;
		public bool Alive { get{return alive;} set{alive = value;} }

		
		public Player (Vector2 initialPosition)
		{
			alive			= true;
			textureInfo 	= new TextureInfo("Application/textures/sprite-Player-Idle.png");
			sprite 			= new SpriteUV();
			sprite			= new SpriteUV(textureInfo);
			//sprite.Position = new Vector2(-14.0f, -7.0f);
			sprite.Position = initialPosition;
			hasJumped		= false;
			isOnGround 		= false;
		}
		
		public void Dispose()
		{
			textureInfo.Dispose();
		}
		
		public void Update()
		{
			var gamePadData = GamePad.GetData(0);
			
			sprite.Position += velocity;
			
			if(sprite.Position.X < -14.5f)
				sprite.Position = new Vector2(-14.5f, sprite.Position.Y);
			if(sprite.Position.X > 13.5f)
				sprite.Position = new Vector2(13.5f, sprite.Position.Y);
			if(sprite.Position.Y == -8.0f)
			{
				hasJumped = false;
				isOnGround = true;
			}
			if(sprite.Position.Y < -8.0f)
			{
				sprite.Position = new Vector2(sprite.Position.X, -8.0f);
				hasJumped = false;
			}
			
			
			if((gamePadData.Buttons & GamePadButtons.Right) != 0)
	        {
	        	velocity.X = 0.1f; 
	        }
			
			else if((gamePadData.Buttons & GamePadButtons.Left) != 0)
	        {
	        	velocity.X = -0.1f;
	        }
			
			else velocity.X = 0.0f;
			
			if((gamePadData.Buttons & GamePadButtons.Cross) != 0 && !hasJumped)
			{
					sprite.Position = new Vector2(sprite.Position.X, sprite.Position.Y + 1.0f);
					velocity.Y = +0.5f;
					isOnGround = false;
					hasJumped = true;
			}
			
			if(hasJumped)
			{		
				velocity.Y -= 0.05f;
			}
			
			if(!hasJumped)
			{
				velocity.Y = 0.0f;
			}
		}
	}
}

