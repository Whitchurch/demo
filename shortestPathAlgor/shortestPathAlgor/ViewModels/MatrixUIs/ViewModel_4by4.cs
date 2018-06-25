using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace shortestPathAlgor.ViewModels.MatrixUIs
{
    class ViewModel_4by4:_ViewModel_Base
    {
        #region "Properties"

        //row - 1
        private int property00 = 0;
        public int Property00
        {
            set { SetProperty(ref property00, value); }
            get { return property00; }
        }

        private int property01 = 0;
        public int Property01
        {
            set { SetProperty(ref property01, value); }
            get { return property01; }
        }

        private int property02 = 0;
        public int Property02
        {
            set { SetProperty(ref property02, value); }
            get { return property02; }
        }

        private int property03 = 0;
        public int Property03
        {
            set { SetProperty(ref property03, value); }
            get { return property03; }
        }


        //row-2
        private int property10 = 0;
        public int Property10
        {
            set { SetProperty(ref property10, value); }
            get { return property10; }
        }

        private int property11 = 0;
        public int Property11
        {
            set { SetProperty(ref property11, value); }
            get { return property11; }
        }

        private int property12 = 0;
        public int Property12
        {
            set { SetProperty(ref property12, value); }
            get { return property12; }
        }

        private int property13 = 0;
        public int Property13
        {
            set { SetProperty(ref property13, value); }
            get { return property13; }
        }

        //row-3
        private int property20 = 0;
        public int Property20
        {
            set { SetProperty(ref property20, value); }
            get { return property20; }
        }

        private int property21 = 0;
        public int Property21
        {
            set { SetProperty(ref property21, value); }
            get { return property21; }
        }

        private int property22 = 0;
        public int Property22
        {
            set { SetProperty(ref property22, value); }
            get { return property22; }
        }

        private int property23 = 0;
        public int Property23
        {
            set { SetProperty(ref property23, value); }
            get { return property23; }
        }

        //row-4
        private int property30 = 0;
        public int Property30
        {
            set { SetProperty(ref property30, value); }
            get { return property30; }
        }

        private int property31 = 0;
        public int Property31
        {
            set { SetProperty(ref property31, value); }
            get { return property31; }
        }

        private int property32 = 0;
        public int Property32
        {
            set { SetProperty(ref property32, value); }
            get { return property32; }
        }

        private int property33 = 0;
        public int Property33
        {
            set { SetProperty(ref property33, value); }
            get { return property33; }
        }

        private string minPathValue = String.Empty;
        public string MinPathValue
        {
            set { SetProperty(ref minPathValue, value); }
            get { return minPathValue; }
        }

        private string nodesOnpath = String.Empty;
        public string NodesOnpath
        {
            set { SetProperty(ref nodesOnpath, value); }
            get { return nodesOnpath; }
        }

        private string travelledFromOneEndofMatrixToNext = String.Empty;
        public string TravelledFromOneEndofMatrixToNext
        {
            set { SetProperty(ref travelledFromOneEndofMatrixToNext, value); }
            get { return travelledFromOneEndofMatrixToNext; }
        }
        #endregion

        private ICommand backCommand;
        public ICommand BackCommand
        {
            get
            {
                return backCommand ?? (backCommand = new Command(() => App.Current.MainPage = new Views.MainMenu.Page_MainMenu()));

            }
        }
        private ICommand calculate4by4Command;
        public ICommand Calculate4by4Command
        {
            get
            {
                return calculate4by4Command ?? (calculate4by4Command = new Command(() => 
                {
                    int[,] sourceMatrix = new int[4,4] { { Property00, Property01, Property02, Property03 }, { Property10, Property11, Property12, Property13 }, { Property20, Property21, Property22, Property23 }, { Property30, Property31, Property32, Property33 } };
                    //int[,]sourceMatrix = new int[4, 4] { { 3, 4, 1 }, { 6, 1, 8 }, { 5, 9, 3 } };
                    Models.ResultFromrun r1 = Helpers.shortestPathHelperFunctions.Main(4, 4, sourceMatrix);
                    MinPathValue = "Minimum path value: " + r1.minpathValue;
                    NodesOnpath = "Nodes on path: " + r1.nodesOnpath;
                    TravelledFromOneEndofMatrixToNext = "Was Matrix colmpleted traversed: " + r1.TravelledFromOneEndofMatrixToNext;
                }));

            }
        }
        public ViewModel_4by4()
        {


           




        }




    }
}
