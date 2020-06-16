using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Xamarin.Forms.Controls.NewControls.Pages
{
	public partial class DemoPage : ContentPage
	{
		public DemoPage()
		{
			InitializeComponent();
			var appBar = new AppBar();
			//TheStack.Children.Add(appBar);
			var tabView = new TabView.TabView();
			TheStack.Children.Add(tabView);
		}
	}
}
