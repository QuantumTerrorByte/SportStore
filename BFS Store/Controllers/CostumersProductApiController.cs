using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SportStore.Infrastructure;
using SportStore.Models;
using SportStore.Models.DAO.Interfaces;
using SportStore.Models.DataTransferModel;
using SportStore.Models.ProductModel;
using SportStore.Models.RequestModel;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers
{
    // [Route("api/[controller]")]
    // [ApiController]
    public class CostumersProductApiController : Controller
    {
        private readonly IProductRepository _productRepository;

        public CostumersProductApiController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public FilteredProductsViewModel GetProducts(ProductsRequestModel requestModel)
        {
            (IList<Product>, int) filteredProducts = _productRepository.GetFilteredProducts(
                new FilteredProductsRepoRequestModel()
                {
                    Category1 = requestModel.Category1,
                    Brand = requestModel.Brand,
                    Sort = requestModel.Sort,
                    MaxPrice = requestModel.MaxPrice,
                    MinPrice = requestModel.MinPrice,
                    Page = requestModel.Page,
                    PageSize = requestModel.PageSize,
                    AttachInfo = false,
                }
            );
            var pagesModel = Paginator.GetPagesModel(
                filteredProducts.Item2,
                requestModel.PageSize,
                requestModel.Page);

            return new FilteredProductsViewModel()
            {
                ProductsList = filteredProducts.Item1,
                Pagination = pagesModel,
            };
        }

        [HttpGet]
        public object GetCategoryAndBrands()
        {
            return new
            {
                categories1 = _productRepository.LangGetCategories(1),
                brands = _productRepository.GetBrands(),
            };
        }

        [HttpGet]
        [SuppressMessage("ReSharper.DPA", "DPA0001: Memory allocation issues")]
        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH")]
        public ProductPageViewModel GetProductPage(int productId) //todo lang & admin log
        {
            Console.Clear();
            var lang = Langs.US;
            var product = _productRepository.GetProduct(productId);
            var info = _productRepository.GetProductInfo(productId, lang); //todo memory issue?
            if (product == null) throw new Exception();
            if (info == null) throw new Exception();

            return new ProductPageViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Brand = product.Brand,
                ImgUrl = product.ImgUrl,
                PriceUSD = product.PriceUsd,
                CategoryFirstLvl = product.NavCategoryFirstLvl,
                CategorySecondLvl = product.NavCategorySecondLvl,
                Info = info,
                Amount = new Random().Next(1,5),
            };
        }
        
    }
}