using System;
using System.Collections.Generic;
using Xamarin.Forms;
using xf_cv_range.ViewModels;
using xf_cv_range.Views;

namespace xf_cv_range
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
