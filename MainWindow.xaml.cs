using System.Drawing;
using System.Windows;

namespace WpfApp5
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			var bmp = new Bitmap(
				"C:/Users/mpatr/Desktop/apple/apple_noise.png"
			//256, 256
			);

			int ratioX = bmp.Width / 256;
			int ratioY = bmp.Height / 256;

			for (int i = 0; i < 256; i++)
				for (int j = 0; j < 256; j++)
					for (int x = 0; x < ratioX; x++)
						for (int y = 0; y < ratioY; y++)
						{
							int c = j;
							if (c > 255)
								c = 255;

							var color = bmp.GetPixel(
								i * ratioX + x,
								j * ratioY + y
							);

							bmp.SetPixel(
								i * ratioX + x,
								j * ratioY + y,
								Color.FromArgb(
									color.R / 2,
									(color.G + c) / 2,
									(color.B + i) / 2
								)
							);
						}

			MainImage.Source = Gradient.ToSource(bmp);
		}
	}
}
