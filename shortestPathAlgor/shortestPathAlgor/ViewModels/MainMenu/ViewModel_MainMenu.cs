using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace shortestPathAlgor.ViewModels.MainMenu
{
    class ViewModel_MainMenu:_ViewModel_Base
    {

        private ICommand calculate4by4Command;
        public ICommand Calculate4by4Command
        {
            get { return calculate4by4Command ?? (calculate4by4Command = new Command(() => App.Current.MainPage = new Views.MatrixUIs.Page_4by4()));

            }
        }

        //private ICommand calculateNbyNCommand;
        //public ICommand CalculateNbyNCommand
        //{
        //    get
        //    {
        //        return calculateNbyNCommand ?? (calculateNbyNCommand = new Command(() => App.Current.MainPage = new Views.Splash.Page_Splash()));

        //    }
        //}


    }
}
