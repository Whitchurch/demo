using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace shortestPathAlgor.CustomControls
{
    public class Custom_Button:Button
    {
        public Custom_Button()
        {
            this.BackgroundColor = Color.Green;
            this.TextColor = Color.White;
            this.BorderRadius = 20;
        }
    }
}
