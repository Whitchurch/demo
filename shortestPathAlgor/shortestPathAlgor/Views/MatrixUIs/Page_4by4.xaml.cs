using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using shortestPathAlgor.ViewModels;
using Xamarin.Forms.Xaml;

namespace shortestPathAlgor.Views.MatrixUIs
{
    
    public partial class Page_4by4 : ContentPage
    {
        ViewModels.MatrixUIs.ViewModel_4by4 ViewModel;
        public Page_4by4()
        {
            try
            {
                InitializeComponent();
                ViewModel = new ViewModels.MatrixUIs.ViewModel_4by4();
                BindingContext = ViewModel;

            }
            catch (System.Exception ex)
            {
                shortestPathAlgor.Helpers.DisplayExceptions.DisplayExceptionMessage(ex);
            }

        }
    }
}