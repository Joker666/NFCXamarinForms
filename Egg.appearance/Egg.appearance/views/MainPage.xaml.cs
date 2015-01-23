using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace Egg.appearance.views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRegisterButtonClick(object sender, EventArgs e)
        {
            DependencyService.Get<INfcTag>().EnableScanMode();
        }
    }
}
