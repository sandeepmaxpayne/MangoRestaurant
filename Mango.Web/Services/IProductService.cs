using Mango.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Web.Services
{
    public interface IProductService
    {
        Task<T> GetAllPrductsAync<T>();
        Task<T> CreateProductAllSink<T>(ProductDto productDto);
        Task<T> GetPrductById<T>(int id);
        Task<T> UpdateProductById<T>(ProductDto productDto);
        Task<T> DeleteProductAsync<T> (int id);
    }
}
