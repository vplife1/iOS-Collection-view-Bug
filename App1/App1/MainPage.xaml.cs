using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        #region Properties
        private SampleListViewModel _ViewModel; 
        #endregion

        #region Constructor
        public MainPage()
        {
            InitializeComponent();
            _ViewModel = new SampleListViewModel();
            this.BindingContext = _ViewModel;
        } 
        #endregion

        #region Override Method
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
        #endregion
    }
}
