using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;

using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace TGPAssignment
{
	public class MenuScreen
	{
		public SpriteUV start, end;
		public TextureInfo startInfo, endInfo;
		
		
		public MenuScreen ()
		{
			startInfo = new TextureInfo("Application/textures/Start-Screen.png");
			start = new SpriteUV(startInfo);
			
			endInfo = new TextureInfo("Application/textures/End Screen.png");
		 	end = new SpriteUV(endInfo);
		}
	}
}

