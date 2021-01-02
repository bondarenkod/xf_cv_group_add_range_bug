using System.ComponentModel;
using Xamarin.Forms;
using xf_cv_range.ViewModels;

namespace xf_cv_range.Views
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