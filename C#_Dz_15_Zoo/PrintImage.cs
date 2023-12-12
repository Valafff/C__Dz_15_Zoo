using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Dz_15_Zoo
{
	internal class Camera
	{
		public void printImage(string arg_path)
		{
			//Image Picture = Image.FromFile(@"1.bmp");
			Image Picture = Image.FromFile(arg_path);
			Console.SetBufferSize((Picture.Width * 0x2), (Picture.Height * 0x2));
			FrameDimension Dimension = new FrameDimension(Picture.FrameDimensionsList[0x0]);
			int FrameCount = Picture.GetFrameCount(Dimension);
			int Left = Console.WindowLeft, Top = Console.WindowTop;
			char[] Chars = { '#', '#', '@', '%', '=', '+', '*', ':', '-', '.', ' ' };
			Picture.SelectActiveFrame(Dimension, 0x0);
			for (int i = 0x0; i < Picture.Height; i++)
			{
				for (int x = 0x0; x < Picture.Width; x++)
				{
					Color Color = ((Bitmap)Picture).GetPixel(x, i);
					int Gray = (Color.R + Color.G + Color.B) / 3;
					int Index = (Gray * (Chars.Length - 1)) / 255;
					Console.Write(Chars[Index]);
				}
				Console.Write('\n');
			}
			Console.SetCursorPosition(Left, Top);
		}
	}
}
