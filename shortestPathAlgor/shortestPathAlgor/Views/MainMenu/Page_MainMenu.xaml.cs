using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using shortestPathAlgor.ViewModels;
namespace shortestPathAlgor.Views.MainMenu
{
   
    public partial class Page_MainMenu : ContentPage
    {
        ViewModels.MainMenu.ViewModel_MainMenu ViewModel;
        public Page_MainMenu()
        {
            try
            {
                InitializeComponent();
                ViewModel = new ViewModels.MainMenu.ViewModel_MainMenu();
                BindingContext = ViewModel;

            }
            catch (System.Exception ex)
            {
                shortestPathAlgor.Helpers.DisplayExceptions.DisplayExceptionMessage(ex);
            }

        }
    }
}