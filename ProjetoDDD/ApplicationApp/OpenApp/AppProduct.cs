using ApplicationApp.Interfaces;
using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.OpenApp
{
    public class AppProduct : InterfaceProductApp
    {
        IProduct _iproduct;
        IServiceProduct _iserviceProduct;

        public AppProduct(IProduct iproduct,IServiceProduct iserviceProduct)
        {
            _iproduct = iproduct;
            _iserviceProduct = iserviceProduct;
        }
        public async Task Add(Product Objeto)
        {
            await _iproduct.Add(Objeto);
        }

        public async Task Delete(Product Objeto)
        {
            await _iproduct.Delete(Objeto);
        }

        public async Task<Product> GetEntityById(int Id)
        {
            return await _iproduct.GetEntityById(Id);
        }

        public async Task<List<Product>> List()
        {
            return await _iproduct.List();
        }
       
        public async Task Update(Product Objeto)
        {
            await _iproduct.Update(Objeto);
        }

        #region Metodos Customizados
        public async Task AddProduct(Product product)
        {
           await _iserviceProduct.AddProduct(product);
        }
        public async  Task UpdateProduct(Product product)
        {
            await _iserviceProduct.UpdateProduct(product);
        }
        #endregion
    }
}
