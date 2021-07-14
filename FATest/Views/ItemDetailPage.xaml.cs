using System.ComponentModel;
using Xamarin.Forms;
using FATest.ViewModels;

namespace FATest.Views
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