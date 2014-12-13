using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;

using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;


namespace TGPAssignment
{
	public class Background
	{
		public float 		ExitSpriteWidth;
		public float 		ExitSpriteHeight;
		public float 		ExitWidth				{get{return ExitSpriteWidth;}}
		public float 		ExitHeight				{get{return ExitSpriteHeight;}}
		public float 		exitSpritePosX			{get{return exitSprite.Position.X;}}
		public float 		exitSpritePosY			{get{return exitSprite.Position.Y;}}
		public			 	SpriteUV 	spriteOne;
		private        		TextureInfo	textureInfoOne;
		public 	        	SpriteUV	spriteTwo;
		private        		TextureInfo textureInfoTwo;
		public 	        	SpriteUV	spriteThree;
		private        		TextureInfo	textureInfoThree;
		public         	 	SpriteUV 	spriteFour;
		private        		TextureInfo textureInfoFour;
		public 	         	SpriteUV	exitSprite;
		private        		TextureInfo textureInfoExitSprite;
		public 				Bounds2 b;
		
		
		public Background()
		{
			textureInfoOne 			= new TextureInfo("Application/textures/Level 1.png");
			spriteOne 				= new SpriteUV();
			spriteOne				= new SpriteUV(textureInfoOne);
			
			textureInfoTwo			= new TextureInfo("Application/textures/Level 2.png");
			spriteTwo 				= new SpriteUV();
			spriteTwo				= new SpriteUV(textureInfoTwo);
			
			textureInfoThree 		= new TextureInfo("Application/textures/Level 3.png");	
			spriteThree 	 		= new SpriteUV ();
			spriteThree 	 		= new SpriteUV (textureInfoThree);
			
			textureInfoFour 		= new TextureInfo("Application/textures/Level 4.png");
			spriteFour 	 			= new SpriteUV ();	
			spriteFour 				= new SpriteUV (textureInfoFour);
			
			textureInfoExitSprite	= new TextureInfo("Application/textures/Exit-Sprite.png");
			exitSprite				= new SpriteUV();
			exitSprite				= new SpriteUV(textureInfoExitSprite);
		}
		
		public void Dispose()
		{
			textureInfoOne.Dispose();
			textureInfoTwo.Dispose();
			textureInfoThree.Dispose();
			textureInfoFour.Dispose();
		}
		
		public void Update()
		{
			Bounds2 b = exitSprite.Quad.Bounds2 ();
			ExitSpriteWidth = b.Point10.X;
			ExitSpriteHeight = b.Point01.Y;
						
			spriteOne.Position 			= new Vector2(-14.0f, -8.0f);
			spriteOne.Scale 			= new Vector2(28.5f, 17.0f);
			
			spriteTwo.Position 			= new Vector2(-14.0f, -8.0f);
			spriteTwo.Scale 			= new Vector2(28.5f, 17.0f);			
			
			spriteThree.Position 		= new Vector2 (-14.0f, -8.0f);
			spriteThree.Scale 			= new Vector2 (28.5f, 17.0f);
			
			spriteFour.Position			= new Vector2 (-14.0f, -8.0f);
			spriteFour.Scale 			= new Vector2 (28.5f, 17.0f);	
			
			exitSprite.Position 		= new Vector2 (8.0f, -7.0f);
		}
		
		
	}
}

