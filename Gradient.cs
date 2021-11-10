using System.Drawing;
using System.Drawing.Imaging;

namespace WpfApp5
{
	public class Gradient
	{
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
