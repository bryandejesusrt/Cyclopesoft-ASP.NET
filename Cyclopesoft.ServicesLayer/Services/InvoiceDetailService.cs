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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Services
{
    public class InvoiceDetailService : IInvoiceDetailService
    {
        public readonly IInvoiceDetailRepository invoiceDetailRepository;
        private readonly ILogger<InvoiceDetailRepository> logger;
        public InvoiceDetailService(IInvoiceDetailRepository invoiceDetailRepository, ILogger<InvoiceDetailRepository> logger)
        {
            this.invoiceDetailRepository = invoiceDetailRepository;
            this.logger = logger;
        }
        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var invoiceDetails = invoiceDetailRepository.GetEntities();

                result.Data = invoiceDetails.Select(inv => new InvoiceDetailModel()
                {
                    Id = inv.Id,
                    Id_Product = inv.Id_Product,
                    Amount = inv.Amount,
                    Sale_Price = inv.Sale_Price,
                    Discout = inv.Discout
                }).ToList();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "There was an error getting the invoice details";
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
                var invoiceDetails = invoiceDetailRepository.GetInvoiceDetailsById(id);

                result.Data = invoiceDetails.Select(inv => new InvoiceDetailModel()
                {
                    Id = inv.Id,
                    Id_Product = inv.Id_Product,
                    Amount = inv.Amount,
                    Sale_Price = inv.Sale_Price,
                    Discout = inv.Discout
                }).ToList();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "There was an error getting the invoice details";
                this.logger.LogError($"{result.Message}: {ex.Message}");
                throw;
            }
            return result;
        }

        public InvoiceDetailResponse RemoveInvoiceDetail(InvoiceDetailRemoveDto invoiceDetailRemoveDto)
        {
            InvoiceDetailRemoveResponse response = new InvoiceDetailRemoveResponse();
            try
            {
                var invoiceDetailDelete = invoiceDetailRepository.GetEntity(Convert.ToInt32(invoiceDetailRemoveDto.Id));
                invoiceDetailDelete.DeleteDate = DateTime.Now;
                invoiceDetailRepository.Remove(invoiceDetailDelete);
                response.Message = "The invoice details was succesfully removed";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "There was an error removing the invoice details";
                this.logger.LogError($"{response.Message}: {ex.Message}");
                throw;
            }
            return response;
        }

        public InvoiceDetailResponse SaveInvoiceDetail(InvoiceDetailSaveDto invoiceDetailSaveDto)
        {
            InvoiceDetailSaveResponse response = new InvoiceDetailSaveResponse();
            try
            {
                var isValidInvoiceDetail = InvoiceDetailValidations.AssertInvoiceDetailIsValid(invoiceDetailSaveDto);

                if (!isValidInvoiceDetail.Success)
                {
                    response.Success = isValidInvoiceDetail.Success;
                    response.Message = isValidInvoiceDetail.Message;
                    return response;
                }
                if (invoiceDetailRepository.Exists(inv => inv.Id == invoiceDetailSaveDto.Id))
                {
                    response.Success = false;
                    response.Message = "These invoice details was already registered";
                    return response;
                }

                var invoiceDetailSave = new InvoiceDetail()
                {
                    Id = Convert.ToInt32(invoiceDetailSaveDto.Id),
                    Id_Product = invoiceDetailSaveDto.Id_Product,
                    Amount = invoiceDetailSaveDto.Amount,
                    Sale_Price = invoiceDetailSaveDto.Sale_Price,
                    Discout = invoiceDetailSaveDto.Discout
                };
                invoiceDetailRepository.Save(invoiceDetailSave);
                response.Message = "The invoice details was saved succesfully";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "There was an error saving the invoice details";
                this.logger.LogError($"{response.Message}: {ex.Message}");
                throw;
            }
            return response;
        }

        public InvoiceDetailResponse UpdateInvoiceDetail(InvoiceDetailUpdateDto invoiceDetailSaveDto)
        {
            InvoiceDetailUpdateResponse response = new InvoiceDetailUpdateResponse();
            try
            {
                var invoiceDetailUpdate = invoiceDetailRepository.GetEntity(Convert.ToInt32(invoiceDetailSaveDto.Id));
                invoiceDetailUpdate.ModifyDate = DateTime.Now;
                invoiceDetailRepository.Update(invoiceDetailUpdate);
                response.Message = "The invoice details was succesfully updated";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "There was an error updating the invoice details";
                this.logger.LogError($"{response.Message}: {ex.Message}");
                throw;
            }
            return response;
        }
    }
}
