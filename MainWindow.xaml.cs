using System.Drawing;
using System.Windows;

namespace WpfApp5
{
	//  0 -1  0
	// -1  5 -1
	//  0 -1  0
	// Wyostrzenie (suma = 1)

	// -1 0 0
	//  0 1 0
	//  0 0 0

	// -1 0 1
	// -2 0 2
	// -1 0 1
	// Wykrywanie krawędzi (Sobel) (suma = 0)

	// 1 2 1
	// 2 4 2
	// 1 2 1
	// Gaussian Blur (suma > 1)

	// 1 1 1
	// 1 1 1
	// 1 1 1
	// Box Blur

	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow() => InitializeComponent();

		private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			var bmp = new Bitmap(
				"C:/Users/mpatr/Desktop/apple/apple_noise.png"
			//256, 256
			);

			MainImage.Source = Gradient.ToSource(
				Gradient.Apply(bmp,
					(int)MainSliderR1.Value,
					(int)MainSliderG1.Value,
					(int)MainSliderB1.Value,
					(int)MainSliderR2.Value,
					(int)MainSliderG2.Value,
					(int)MainSliderB2.Value
				)
			);
		}
	}
}
