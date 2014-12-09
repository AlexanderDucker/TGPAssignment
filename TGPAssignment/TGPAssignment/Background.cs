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
		public			 SpriteUV	spriteThree;
		private static TextureInfo	textureInfoThree;
		public 			 SpriteUV spriteFour;
		private static TextureInfo textureInfoFour;


		
		public Background()
		{
			textureInfoOne 		= new TextureInfo("Application/textures/Level 2.png");
			spriteOne 			= new SpriteUV();
			spriteOne			= new SpriteUV(textureInfoOne);
			
			textureInfoThree 	= new TextureInfo("Application/textures/Level 3.png");	
			spriteThree 	 	= new SpriteUV ();
			spriteThree 	 	= new SpriteUV (textureInfoThree);
			
			textureInfoFour 	= new TextureInfo("Application/textures/Level 4.png");
			spriteFour 	 		= new SpriteUV ();	
			spriteFour 			= new SpriteUV (textureInfoFour);
		}
		
		public void Dispose()
		{
			textureInfoOne.Dispose();
			textureInfoThree.Dispose();
			textureInfoFour.Dispose();
		}
		
		public void Update()
		{
			spriteOne.Position = new Vector2(-14.0f, -8.0f);
			Console.WriteLine(spriteOne.Position);
			spriteOne.Scale = new Vector2(28.5f,17f);
			
			spriteThree.Position = new Vector2 (-14.0f, -8.0f);
			spriteThree.Scale = new Vector2 (28.5f, 17.0f);
			
			spriteFour.Position = new Vector2 (-14.0f, -8.0f);
			spriteFour.Scale = new Vector2 (-14.0f, -8.0f);
		}
		
		
	}
}

