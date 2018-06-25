using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace shortestPathAlgor.ViewModels.Splash
{
    class ViewModel_Splash:_ViewModel_Base
    {
        #region "Properties"
        string splashScreenText = String.Empty;

        public string PropertySplashScreenText
        {
            set { SetProperty(ref splashScreenText, value); }
            get { return splashScreenText; }
        }

        string loader = String.Empty;

        public string PropertyLoader
        {
            set { SetProperty(ref loader, value); }
            get { return loader; }
        }

        #endregion

        public ViewModel_Splash()
        {
            DisplaySplashScreenMessages();
        }

        private async void DisplaySplashScreenMessages()
        {

            PropertySplashScreenText = "SPLASH SCREEN";
            await Task.Delay(1000);


            //Spoofing a loader for special FX.. will not do something like this in real life production code, just for simulation purposes
            PropertyLoader = "25%....";
            await Task.Delay(1000);
            PropertyLoader = "55%....";
            await Task.Delay(1000);
            PropertyLoader = "95%....";
            await Task.Delay(1000);
            PropertyLoader = "100%";

            Device.BeginInvokeOnMainThread(() => App.Current.MainPage = new Views.MainMenu.Page_MainMenu());
            



        }
    }
}
