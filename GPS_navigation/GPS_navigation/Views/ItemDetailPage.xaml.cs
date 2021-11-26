using System.ComponentModel;
using Xamarin.Forms;
using GPS_navigation.ViewModels;

namespace GPS_navigation.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}