using System;

using Xamarin.Forms;
using shortestPathAlgor;
using shortestPathAlgor.Views;

namespace shortestPathAlgor
{
	public class App : Application
	{
		public App ()
		{
            // The root page of your application
            MainPage = new Views.Splash.Page_Splash();
            
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

