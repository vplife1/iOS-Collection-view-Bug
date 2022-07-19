using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleListView : ContentPage
    {
        private SampleListViewModel _ViewModel;
        public SampleListView()
        {
            try
            {
                InitializeComponent();
                _ViewModel = new SampleListViewModel();
                this.BindingContext = _ViewModel;
            }
            catch (Exception ex)
            {
            }
        }

        protected override void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                _ViewModel = this.BindingContext as SampleListViewModel;
                if (_ViewModel != null)
                    _ViewModel.MockData();
            }
            catch (Exception ex)
            {
            }
        }
    }
}