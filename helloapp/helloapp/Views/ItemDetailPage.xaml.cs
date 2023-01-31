using helloapp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace helloapp.Views
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