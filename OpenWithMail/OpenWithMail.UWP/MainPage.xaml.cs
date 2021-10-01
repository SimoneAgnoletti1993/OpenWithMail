using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace OpenWithMail.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new OpenWithMail.App());
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is string && !string.IsNullOrWhiteSpace((string)e.Parameter))
            {
                Uri uri = new Uri(e.Parameter.ToString());
                LoadApplication(new OpenWithMail.App(uri));
            }
            else
            {
                LoadApplication(new OpenWithMail.App());
            }
            base.OnNavigatedTo(e);
        }
    }
}
