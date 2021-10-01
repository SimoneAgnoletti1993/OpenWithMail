using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OpenWithMail
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string hexcolor, string testo, string uri = null)
        {
            InitializeComponent();
            Frame.BackgroundColor = Color.FromHex("#" + hexcolor);
            Label.Text = testo;
        }


    }
}
