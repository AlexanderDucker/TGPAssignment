using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;

using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace TGPAssignment
{
	public class Obstacle
	{
		public float 		ObstacleOneSpriteWidth;
		public float 		ObastacleOneSpriteHeight;
//		public float 		ObstacleOneWidth				{get{return ExitSpriteWidth;}}
//		public float 		ObstacleOneHeight				{get{return ExitSpriteHeight;}}
//		public float 		exitSpritePosX			{get{return exitSprite.Position.X;}}
//		public float 		exitSpritePosY			{get{return exitSprite.Position.Y;}}
		public 				SpriteUV 	spriteObstacleOne;
		private      		TextureInfo textureInfoObstacleOne;
		
		public Obstacle ()
		{
			
			
			textureInfoObstacleOne  =	new TextureInfo("Application/textures/Vehicle Obstacle.png");
			spriteObstacleOne		=	new SpriteUV();
			spriteObstacleOne		= 	new SpriteUV(textureInfoObstacleOne);
			spriteObstacleOne.Position  = new Vector2 (-2.0f, -8.5f);
			spriteObstacleOne.Scale = new Vector2(3.0f, 3.0f);

		}
		
		public void Dispose()
		{
			textureInfoObstacleOne.Dispose ();
		}
		
		public void Update()
		{
		}
	}
}

