using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;

using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;


namespace TGPAssignment
{
	public class Player
	{
		public			 SpriteUV 	sprite;
		private static TextureInfo	textureInfo;
		private static bool 		alive;
		
		public bool Alive { get{return alive;} set{alive = value;} }


		
		public Player ()
		{
			alive			= true;
			textureInfo 	= new TextureInfo("Application/textures/sprite-Player-Idle.png");
			sprite 			= new SpriteUV();
			sprite			= new SpriteUV(textureInfo);
			//sprite.Position = new Vector2(50.0f, 50.0f);
		}
		
		public void Dispose()
		{
			textureInfo.Dispose();
		}
		
		public void Update()
		{
			sprite.Position = new Vector2(-14.0f, -8.0f);
			//Console.WriteLine(spriteOne.Position);
		}
		
		
	}
}

