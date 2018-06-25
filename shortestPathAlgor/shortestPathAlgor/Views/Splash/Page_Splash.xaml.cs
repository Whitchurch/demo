using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using shortestPathAlgor.ViewModels;
using Xamarin.Forms.Xaml;

namespace shortestPathAlgor.Views.Splash
{
    
    public partial class Page_Splash : ContentPage
    {
        ViewModels.Splash.ViewModel_Splash ViewModel;
        public Page_Splash()
        {
            try
            {
                InitializeComponent();
                ViewModel = new ViewModels.Splash.ViewModel_Splash();
                BindingContext = ViewModel;

            }
            catch(System.Exception ex)
            {
                shortestPathAlgor.Helpers.DisplayExceptions.DisplayExceptionMessage(ex);
            }
           
        }
    }
}