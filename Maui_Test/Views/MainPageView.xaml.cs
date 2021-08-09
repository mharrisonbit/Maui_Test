using System;
using Microsoft.Maui.Controls;

namespace Maui_Test.Views
{
	public partial class MainPageView : ContentPage
	{
		public MainPageView()
		{
			InitializeComponent();
		}

		int count = 0;
		private void OnCounterClicked(object sender, EventArgs e)
		{
			count++;
			CounterLabel.Text = $"Current count: {count}";
		}
	}
}
