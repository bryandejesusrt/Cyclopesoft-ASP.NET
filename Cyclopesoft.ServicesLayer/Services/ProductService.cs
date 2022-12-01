
using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.DataLayer.Interface;
using Cyclopesoft.DataLayer.Repository;
using Cyclopesoft.ServicesLayer.Contracts;
using Cyclopesoft.ServicesLayer.Core;
using Cyclopesoft.ServicesLayer.Dtos;
using Cyclopesoft.ServicesLayer.Models;
using Cyclopesoft.ServicesLayer.Responses;
using Cyclopesoft.ServicesLayer.Validations;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;


namespace Cyclopesoft.ServicesLayer.Services
{
    public class ProductService : IProductService
    {
        public readonly IProductRepository productRepository;
        private readonly ILogger<ProductRepository> logger;

        public ProductService(IProductRepository productRepository, ILogger<ProductRepository> logger)
        {
            this.productRepository = productRepository;
            this.logger = logger;
        }

        public ServiceResult GetAll()
        {

            ServiceResult result = new ServiceResult();
            try
            {
                var products = productRepository.GetEntities();

                result.Data = products.Select(prd => new ProductModel()
                {
                    Id = prd.Id,
                    Bar_Code = prd.Bar_Code,
                    Name = prd.Name,
                    Description = prd.Description,
                    Distribution = prd.Distribution,
                    Image = prd.Image,
                    Cost_Price = prd.Cost_Price,
                    Gain = prd.Gain,
                    Sale_Price = prd.Sale_Price,
                    Wholesale_Price = prd.Wholesale_Price,
                    Minimum = prd.Minimum,
                    Maximum = prd.Maximum,
                    Stock = prd.Stock
                }).ToList();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "There was an error getting the product";
                this.logger.LogError($"{result.Message}: {ex.Message}");
                throw;
            }
            return result;
        }

        public ServiceResult GetById(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var products = productRepository.GetProductById(id);

                result.Data = products.Select(prd => new ProductModel()
                {
                    Id = prd.Id,
                    Bar_Code = prd.Bar_Code,
                    Name = prd.Name,
                    Description = prd.Description,
                    Distribution = prd.Distribution,
                    Image = prd.Image,
                    Cost_Price = prd.Cost_Price,
                    Gain = prd.Gain,
                    Sale_Price = prd.Sale_Price,
                    Wholesale_Price = prd.Wholesale_Price,
                    Minimum = prd.Minimum,
                    Maximum = prd.Maximum,
                    Stock = prd.Stock
                }).ToList();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "There was an error getting the product";
                this.logger.LogError($"{result.Message}: {ex.Message}");
                throw;
            }
            return result;
        }

        public ProductResponse RemoveProduct(ProductRemoveDto productRemoveDto)
        {
            ProductRemoveResponse response = new ProductRemoveResponse();
            try
            {
                var productDelete = productRepository.GetEntity(Convert.ToInt32(productRemoveDto.Id));
                productDelete.DeleteDate = DateTime.Now;
                productRepository.Remove(productDelete);
                response.Message = "The product was succesfully removed";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "There was an error removing the product";
                this.logger.LogError($"{response.Message}: {ex.Message}");
                throw;
            }
            return response;
        }

        public ProductResponse SaveProduct(ProductSaveDto productSaveDto)
        {
            ProductSaveResponse response = new ProductSaveResponse();
            try
            {
                var isValidProduct = ProductValidations.AssertProductIsValid(productSaveDto);

                if (!isValidProduct.Success)
                {
                    response.Success = isValidProduct.Success;
                    response.Message = isValidProduct.Message;
                    return response;
                }
                if (productRepository.Exists(inv => inv.Id == productSaveDto.Id))
                {
                    response.Success = false;
                    response.Message = "This Product was already registered";
                    return response;
                }

                var productSave = new Product()
                {
                    Id = Convert.ToInt32(productSaveDto.Id),
                    Bar_Code = productSaveDto.Bar_Code,
                    Name = productSaveDto.Name,
                    Description = productSaveDto.Description,
                    Distribution = productSaveDto.Distribution,
                    Image = productSaveDto.Image,
                    Cost_Price = productSaveDto.Cost_Price,
                    Gain = productSaveDto.Gain,
                    Sale_Price = productSaveDto.Sale_Price,
                    Wholesale_Price = productSaveDto.Wholesale_Price,
                    Minimum = productSaveDto.Minimum,
                    Maximum = productSaveDto.Maximum,
                    Stock = productSaveDto.Stock
                };
                productRepository.Save(productSave);
                response.Message = "The product was saved succesfully";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "There was an error saving the product";
                this.logger.LogError($"{response.Message}: {ex.Message}");
                throw;
            }
            return response;
        }

        public ProductResponse UpdateProduct(ProductUpdateDto productSaveDto)
        {
            ProductUpdateResponse response = new ProductUpdateResponse();
            try
            {
                var productUpdate = productRepository.GetEntity(Convert.ToInt32(productSaveDto.Id));
                productUpdate.ModifyDate = DateTime.Now;
                productRepository.Update(productUpdate);
                response.Message = "The product was succesfully updated";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "There was an error updating the product";
                this.logger.LogError($"{response.Message}: {ex.Message}");
                throw;
            }
            return response;
        }
    }
}
