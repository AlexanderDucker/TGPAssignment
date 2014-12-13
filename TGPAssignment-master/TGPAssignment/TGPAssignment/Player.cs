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
		public float 		PlayerSpriteWidth;
		public float 		PlayerSpriteHeight;
		public float 		PlayerWidth			{get{return PlayerSpriteWidth;}}
		public float 		PlayerHeight		{get{return PlayerSpriteHeight;}}
		public float 		PlayerPosX			{get{return sprite.Position.X;}}
		public float 		PlayerPosY			{get{return sprite.Position.Y;}}
		public			 	SpriteUV 			sprite;
		private static 		TextureInfo			textureInfo;
		private static bool 					alive;
		private float							yVelocity;
		private float							gravity;
		private bool							isJumping;
		private float							yDestination;
		public bool 		Alive 				{ get{return alive;} set{alive = value;} }
		public 		 		Bounds2 			b;
		Background Exit;
		public bool 		collision;
		public float 		exitSpriteX;
		public float 		exitSpriteY;
		public float 		exitSpriteDisplacementX {get{return Exit.exitSprite.Position.X + 8.0f;}}
//		public float		exitSpriteDisplacementY {get{return Exit.exitSprite.Position.Y + ??f;}}
		
		public Player ()
		{
//			exitSpriteDisplacement = new Vector2 (exitSpriteX + 5.0f, exitSpriteY);
			Exit = new Background();
			alive			= true;
			textureInfo 	= new TextureInfo("Application/textures/sprite-Player-Idle.png");
			sprite 			= new SpriteUV();
			sprite			= new SpriteUV(textureInfo);
			sprite.Position = new Vector2(-14.0f, -7.0f);
			yVelocity		= 0.92f;
			gravity			= 0.2f;
			isJumping		= false;
		}
		
		public void Dispose()
		{
			textureInfo.Dispose();
		}
		
		public void Update()
		{
			Bounds2 b = sprite.Quad.Bounds2 ();
			PlayerSpriteWidth = b.Point10.X;
			PlayerSpriteHeight = b.Point01.Y;
			
			exitSpriteX = Exit.exitSpritePosX + exitSpriteDisplacementX;
			exitSpriteY = Exit.exitSpritePosY;
			
			if (PlayerPosX >= exitSpriteX)
			{
				Console.WriteLine ("do something");
				sprite.Position = new Vector2(sprite.Position.X -0.1f, sprite.Position.Y);
			}
				
			
			var gamePadData = GamePad.GetData(0);
			if((gamePadData.Buttons & GamePadButtons.Right) != 0)
	        {
	        	sprite.Position = new Vector2(sprite.Position.X + 0.1f, sprite.Position.Y);  
	        }
			
			if((gamePadData.Buttons & GamePadButtons.Left) != 0)
	        {
	        	sprite.Position = new Vector2(sprite.Position.X - 0.1f, sprite.Position.Y);  
	        }
			
			if((gamePadData.Buttons & GamePadButtons.Cross) != 0)
			{
				if(!isJumping)
				{
					isJumping = true;
					yDestination = sprite.Position.Y + 1.5f;
					while(yDestination > sprite.Position.Y)
					{	
						sprite.Position = new Vector2(sprite.Position.X, sprite.Position.Y * yVelocity);
						isJumping = false;
					}
				}						
			}
		}
	}
}

