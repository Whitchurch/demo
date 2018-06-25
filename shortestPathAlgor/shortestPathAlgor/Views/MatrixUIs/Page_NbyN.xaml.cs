using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shortestPathAlgor.Views.MatrixUIs
{
    
    public partial class Page_NbyN : ContentPage
    {
        ViewModels.MatrixUIs.ViewModel_NbyN ViewModel;
        public Page_NbyN()
        {
            try
            {
                InitializeComponent();
                ViewModel = new ViewModels.MatrixUIs.ViewModel_NbyN();
                BindingContext = ViewModel;

            }
            catch (System.Exception ex)
            {
                shortestPathAlgor.Helpers.DisplayExceptions.DisplayExceptionMessage(ex);
            }

        }
    }
}