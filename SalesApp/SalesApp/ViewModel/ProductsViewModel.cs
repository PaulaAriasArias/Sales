using GalaSoft.MvvmLight.Command;
using SalesApp.Helpers;
using SalesApp.Services;
using SalesCommon.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SalesApp.ViewModel
{
    public class ProductsViewModel : BaseViewModel
    {
        private ApiService apiService;

        private bool isRefreshing { get; set; }

        

        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); } 
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { ; }
        }

        public ProductsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();
        }

        private async void LoadProducts()
        {
            this.IsRefreshing = true;

            


            var connection = await this.apiService.CheckConnection();
            if(!connection.IsSuccess)
            {
                //this.IsRefreshing = false;
                //await Application.Current.MainPage.DisplayAlert(Languages.Error, connection.Message, Languages.Accept);
                await Application.Current.MainPage.DisplayAlert("Error", connection.Message, "Aceptar");
                return;
            }


            //var url = Application.Current.Resources["UrlAPI"].ToString();
            //var prefix = Application.Current.Resources["Prefix"].ToString();
            //var controller = Application.Current.Resources["UrlProductsController"].ToString()

            //*******************************
            //var response1 = await this.apiService.GetRestaurants();

            //*******************************

            var response = await this.apiService.GetListGen<Product>("http://179.12.106.203/ApiSalesNet", "/api", "/Products");
            //var response = await this.apiService.GetList<Product>("http://179.12.106.203/ApiSalesNet", "/api", "/Products");
            //var response = await this.apiService.GetList<Product>("http://localhost/ApiSalesNet/", "/api", "/Products");
            // var response = await this.apiService.GetList<Product>(url, prefix, controller);
            if (!response.IsSuccess)
            {
                this.IsRefreshing = false;
                //await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Aceptar");
                await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Aceptar");
                return;
            }

            var list = (List<Product>)response.Result;
            this.Products = new ObservableCollection<Product>(list);

            this.IsRefreshing = false;
        }

        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(LoadProducts);
            }

        }
    }
}
