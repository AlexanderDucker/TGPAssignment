using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;

using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace TGPAssignment
{
	public class Obstacle
	{
		public 				SpriteUV 	spriteObstacleOne;
		private      		TextureInfo textureInfoObstacleOne;
		public				SpriteUV	branchSprite;
		private				TextureInfo branchTextureInfo;
		public Bounds2 bounds;
		
		public Obstacle (Vector2 position)
		{
			textureInfoObstacleOne  =	new TextureInfo("Application/textures/Vehicle Obstacle.png");
			spriteObstacleOne		=	new SpriteUV();
			spriteObstacleOne		= 	new SpriteUV(textureInfoObstacleOne);
			spriteObstacleOne.Position  = new Vector2 (-2.0f, -8.5f);
			spriteObstacleOne.Scale = new Vector2(3.0f, 3.0f);
			
			branchTextureInfo 		= new TextureInfo("Application/textures/Tree Platform.png");
			branchSprite 			= new SpriteUV();
			branchSprite 			= new SpriteUV(branchTextureInfo);
			branchSprite.Scale = new Vector2(3.7f, 0.8f);
			

			
			branchSprite.Position = position;
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

