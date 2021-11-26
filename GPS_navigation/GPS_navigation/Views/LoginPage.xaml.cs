using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPS_navigation.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GPS_navigation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.Visual = VisualMarker.Material;
            this.BindingContext = new LoginViewModel();
        }
    }
}