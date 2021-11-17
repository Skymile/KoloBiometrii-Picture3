using System.Drawing;
using System.Drawing.Imaging;

namespace WpfApp5
{
	public class Gradient
	{
		public static Bitmap Apply(
				Bitmap bmp,
				int r1, int g1, int b1,
				int r2, int g2, int b2
			)
		{
			return bmp;
			/*
			int ratioX = bmp.Width / 256;
			int ratioY = bmp.Height / 256;

			for (int i = 0; i < 256; i++)
				for (int j = 0; j < 256; j++)
					for (int x = 0; x < ratioX; x++)
						for (int y = 0; y < ratioY; y++)
						{
							int r1 = (int)MainSliderR1.Value - i;
							int g1 = (int)MainSliderG1.Value - i;
							int b1 = (int)MainSliderB1.Value - i;

							int r2 = i - 255 + (int)MainSliderR2.Value;
							int g2 = i - 255 + (int)MainSliderG2.Value;
							int b2 = i - 255 + (int)MainSliderB2.Value;

							if (r1 > 255) r1 = 255;
							if (g1 > 255) g1 = 255;
							if (b1 > 255) b1 = 255;
							if (r2 > 255) r2 = 255;
							if (g2 > 255) g2 = 255;
							if (b2 > 255) b2 = 255;

							if (r1 < 0) r1 = 0;
							if (g1 < 0) g1 = 0;
							if (b1 < 0) b1 = 0;
							if (r2 < 0) r2 = 0;
							if (g2 < 0) g2 = 0;
							if (b2 < 0) b2 = 0;

							var color = bmp.GetPixel(
								i * ratioX + x,
								j * ratioY + y
							);

							bmp.SetPixel(
								i * ratioX + x,
								j * ratioY + y,
								Color.FromArgb(
									(color.R + r1 + r2) / 2,
									(color.G + g1 + g2) / 2,
									(color.B + b1 + b2) / 2
								)
							);
						}
				*/
		}

		public static System.Windows.Media.Imaging.BitmapSource ToSource(Bitmap bmp)
		{
			var data = bmp.LockBits(
				new Rectangle(Point.Empty, bmp.Size),
				ImageLockMode.ReadWrite,
				PixelFormat.Format24bppRgb
			);

			var bmpSource = System.Windows.Media.Imaging.BitmapSource.Create(
				data.Width,
				data.Height,
				96, 96,
				System.Windows.Media.PixelFormats.Bgr24,
				null,
				data.Scan0,
				data.Stride * data.Height,
				data.Stride
			);

			bmp.UnlockBits(data);
			return bmpSource;
		}
	}
}
