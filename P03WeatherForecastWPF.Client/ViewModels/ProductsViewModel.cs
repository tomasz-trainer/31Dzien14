using CommunityToolkit.Mvvm.ComponentModel;
using P06Shop.Shared;
using P06Shop.Shared.Services.ProductService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace P03WeatherForecastWPF.Client.ViewModels
{
    public partial class ProductsViewModel : ObservableObject
    {

        private readonly IProductService _productService;

        [ObservableProperty]
        private ObservableCollection<Product> _products;

        [ObservableProperty]
        private Product _selectedProduct;

        [ObservableProperty]
        private string _errorMessage;

        public ProductsViewModel(IProductService productService)
        {
            _productService = productService;
        }

        public async Task LoadProductsAsync()
        {
            var response = await _productService.GetProductsAsync();
            if (response.Success && response.Data != null)
            {
                Products = new ObservableCollection<Product>(response.Data);
            }
            else
            {
                // Handle error (e.g., log it, show a message to the user, etc.)
                 Products = new ObservableCollection<Product>();
            }
        }

      

        public async Task CreateProductAsync()
        {
            var result = await _productService.CreateProductAsync(_selectedProduct);
            if (result.Success)
            {
                await LoadProductsAsync();
            }
            else
            {
                _errorMessage = "Error creating product: " + result.Message;
            }
        }

        public async Task UpdateProductAsync()
        {
            var result = await _productService.UpdateProductAsync(_selectedProduct);
            if (result.Success)
            {
                await LoadProductsAsync();
            }
            else
            {
                _errorMessage = "Error updating product: " + result.Message;
            }
        }

        public async Task DeleteProductAsync()
        {
            if (_selectedProduct == null)
            {
                _errorMessage = "No product selected for deletion.";
                return;
            }
            var result = await _productService.DeleteProductAsync(_selectedProduct.Id);
            if (result.Success)
            {
                await LoadProductsAsync();
            }
            else
            {
                _errorMessage = "Error deleting product: " + result.Message;
            }
        }

    }
}
