using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TicTacToe_UWP
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		SymbolIcon cross = new SymbolIcon(Symbol.Cancel);
		SymbolIcon circle = new SymbolIcon(Symbol.Target);

		int ctr = 0;
		int[] buttons = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

		public MainPage()
		{
			this.InitializeComponent();
		}

		private void ButtonClick(ToggleButton tb)
		{
			// tb.Content = cross;
			tb.IsEnabled = false;
		}

		private void StartAfresh(object sender, RoutedEventArgs e)
		{
			ctr = 0;

			if (this.FindName("MainGrid") is Grid grid)
				foreach (var button in grid.Children.OfType<ToggleButton>())
				{
					button.IsEnabled = true; button.IsChecked = false;
				}
		}

		private async void DisplayAboutDialog(object sender, RoutedEventArgs e)
		{
			await aboutDlg.ShowAsync();
		}

		private void rc00_Click(object sender, RoutedEventArgs e)
		{
			ctr++;
		}

		private void rc01_Click(object sender, RoutedEventArgs e)
		{

		}

		private void rc02_Click(object sender, RoutedEventArgs e)
		{

		}

		private void rc10_Click(object sender, RoutedEventArgs e)
		{

		}

		private void rc11_Click(object sender, RoutedEventArgs e)
		{

		}

		private void rc12_Click(object sender, RoutedEventArgs e)
		{

		}

		private void rc20_Click(object sender, RoutedEventArgs e)
		{

		}

		private void rc21_Click(object sender, RoutedEventArgs e)
		{

		}

		private void rc22_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}