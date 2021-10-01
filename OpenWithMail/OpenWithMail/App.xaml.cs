using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OpenWithMail
{
    public partial class App : Application
    {
        public App(Uri uri = null)
        {
            InitializeComponent();
            lanchApp(uri);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        protected override void OnAppLinkRequestReceived(Uri uri)
        {
            base.OnAppLinkRequestReceived(uri);

            lanchApp(uri);
        }
        public bool OnlyHexInString(string test)
        {
            // For C-style hex notation (0xFF) you can use @"\A\b(0[xX])?[0-9a-fA-F]+\b\Z"
            return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");
        }

        public void lanchApp(Uri uri)
        {
            if (uri != null)
            {
                if (uri.Host.ToLower() == "appwithmail" && uri.Segments != null && uri.Segments.Length == 3 && (uri.Segments[2].Length == 3 || uri.Segments[2].Length == 6))
                {
                    bool isParameterValid = OnlyHexInString(uri.Segments[2]);
                    if (isParameterValid)
                    {
                        MainPage = new MainPage(uri.Segments[2], "Mi sono aperta tramite una mail!!!");
                    }
                    else
                    {

                        MainPage = new MainPage("2196F3", "Mi sono aperta tramite una mail!!!");
                    }
                }
                else
                {
                    MainPage = new MainPage("2196F3", "Mi sono aperta tramite una mail!!!");
                }
            }
            else
            {
                MainPage = new MainPage("2196F3", "Mi sono aperta normalmente :(");
            }
        }
    }
}
