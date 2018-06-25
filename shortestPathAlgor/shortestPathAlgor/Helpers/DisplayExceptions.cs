using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
 

namespace shortestPathAlgor.Helpers
{
    public static class DisplayExceptions
    {

        public static void DisplayExceptionMessage(Exception exception)
        {
           Device.BeginInvokeOnMainThread(() => Application.Current.MainPage.DisplayAlert("Error", exception.Message, "OK"));
        }

    }
}
