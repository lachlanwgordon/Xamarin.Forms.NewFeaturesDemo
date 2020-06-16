using System;
using Xamarin.Forms;

namespace NewControlsDemo.Views
{
	public class NewPage : ContentPage
	{
		public NewPage()
		{
			Content = new StackLayout
			{
				Children =
				{

					new Label {Text = "Hello"},
					new Label {Text = "Hello"},
					new Label {Text = "Hello"},
					new Label {Text = "Hello"},
					new Label {Text = "Hello"},
				}
			};

		}


	}
}
