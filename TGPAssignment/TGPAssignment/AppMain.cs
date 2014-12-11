using System;
using System.Collections.Generic;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.HighLevel.GameEngine2D;

namespace TGPAssignment
{
	public class AppMain
	{
		private static GraphicsContext graphics;
		
		
		public static void Main (string[] args)
		{
			
			Initialize ();

			while (true) {
				SystemEvents.CheckEvents ();
				Director.Instance.Update();
				Director.Instance.Render();
				
				Director.Instance.GL.Context.SwapBuffers(); // Swap between back and front buffer
				Director.Instance.PostSwap();
			}
			Director.Terminate();
		}

		public static void Initialize ()
		{	
			
			bool LevelOne = true;
			bool LevelThree = false;
			
			// Set up the graphics system
			//graphics = new GraphicsContext ();
			
			Director.Initialize();
			if(LevelOne == true)
			{
			Director.Instance.RunWithScene(new LevelOne(),false);
			}
			if(LevelThree == true)
			{
			Director.Instance.RunWithScene (new LevelThree(), false);	
			}
			
		}

		
	}
}
