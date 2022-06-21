using System.ComponentModel;
using Xamarin.Forms;
using TestPipeline.ViewModels;

namespace TestPipeline.Views
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
