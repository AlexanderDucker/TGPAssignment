using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;

using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;


namespace TGPAssignment
{
	public class Background
	{
		public			 SpriteUV 	spriteOne;
		private static TextureInfo	textureInfoOne;


		
		public Background()
		{
			textureInfoOne 	= new TextureInfo("Application/LevelOne.png");
			spriteOne 			= new SpriteUV();
			spriteOne			= new SpriteUV(textureInfoOne);
			
		}
		
		public void Dispose()
		{
			textureInfoOne.Dispose();
		}
		
		public void Update()
		{
			spriteOne.Position = new Vector2(-14.0f, -8.0f);
			Console.WriteLine(spriteOne.Position);
			spriteOne.Scale = new Vector2(28.5f,17f);
		}
		
		
	}
}

