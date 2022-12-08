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
using System.Numerics;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Services
{
    public class InvoiceService : IInvoiceService
    {
        public readonly IInvoiceRepository invoiceRepository;
        private readonly ILogger<InvoiceRepository> logger;

        public InvoiceService(IInvoiceRepository invoiceRepository, ILogger<InvoiceRepository> logger)
        {
            this.invoiceRepository = invoiceRepository;
            this.logger = logger;
        }

        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var invoices = invoiceRepository.GetEntities();

                result.Data = invoices.Select(inv => new InvoiceModel()
                {
                    Id = inv.Id,
                    Serie = inv.Serie,
                    RNC = inv.RNC,
                    Expiration_Date = inv.Expiration_Date,
                    Payment_Type = inv.Payment_Type,
                    Client_Id = inv.Client_Id,
                    User_Id = inv.User_Id,
                    Subtotal = inv.Subtotal,
                    Taxes = inv.Taxes,
                    Total = inv.Total,
                    Status = inv.Status,
                    Note = inv.Note
                }).ToList();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "There was an error getting the invoice";
                this.logger.LogError($"{result.Message}: {ex.Message}");
                
            }
            return result;
        }

        public ServiceResult GetById(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var invoices = invoiceRepository.GetInvoiceById(id);

                result.Data = invoices.Select(invoice => new InvoiceModel()
                {
                    Id = invoice.Id,
                    Serie = invoice.Serie,
                    RNC = invoice.RNC,
                    Expiration_Date = invoice.Expiration_Date,
                    Payment_Type = invoice.Payment_Type,
                    Client_Id = invoice.Client_Id,
                    User_Id = invoice.User_Id,
                    Subtotal = invoice.Subtotal,
                    Taxes = invoice.Taxes,
                    Total = invoice.Total,
                    Status = invoice.Status,
                    Note = invoice.Note
                }).ToList();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "There was an error getting the invoice";
                this.logger.LogError($"{result.Message}: {ex.Message}");
                throw;
            }
            return result;
        }

        public InvoiceRemoveResponse RemoveInvoice(InvoiceRemoveDto invoiceRemoveDto)
        {
            InvoiceRemoveResponse response = new InvoiceRemoveResponse();
            try
            {
                var invoiceDelete = invoiceRepository.GetEntity(Convert.ToInt32(invoiceRemoveDto.Id));
                invoiceDelete.DeleteDate = DateTime.Now;
                invoiceRepository.Remove(invoiceDelete);
                response.Message = "The invoice was succesfully removed";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "There was an error removing the invoice";
                this.logger.LogError($"{response.Message}: {ex.Message}");
                throw;
            }
            return response;
        }

        public InvoiceSaveResponse SaveInvoice(InvoiceSaveDto invoiceSaveDto)
        {
            InvoiceSaveResponse response = new InvoiceSaveResponse();
            try
            {
                var isValidInvoice = InvoiceValidations.AssertInvoiceIsValid(invoiceSaveDto);

                if (!isValidInvoice.Success)
                {
                    response.Success = isValidInvoice.Success;
                    response.Message = isValidInvoice.Message;
                    return response;
                }
                if (invoiceRepository.Exists(inv => inv.Id == invoiceSaveDto.Id))
                {
                    response.Success = false;
                    response.Message = "This invoice was already registered";
                    return response;
                }

                var invoiceSave = new Invoice()
                {
                    Serie = invoiceSaveDto.Serie,
                    RNC = invoiceSaveDto.RNC,
                    Expiration_Date = invoiceSaveDto.Expiration_Date,
                    Payment_Type = invoiceSaveDto.Payment_Type,
                    Client_Id = invoiceSaveDto.Client_Id,
                    User_Id = invoiceSaveDto.User_Id,
                    Subtotal = invoiceSaveDto.Subtotal,
                    Taxes = invoiceSaveDto.Taxes,
                    Total = invoiceSaveDto.Total,
                    Status = invoiceSaveDto.Status,
                    Note = invoiceSaveDto.Note
                };
                invoiceRepository.Save(invoiceSave);
                response.Message = "The invoice was saved succesfully";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "There was an error saving the invoice";
                this.logger.LogError($"{response.Message}: {ex.Message}");
                throw;
            }
            return response;
        }

        public InvoiceUpdateResponse UpdateInvoice(InvoiceUpdateDto invoiceSaveDto)
        {
            InvoiceUpdateResponse response = new InvoiceUpdateResponse();
            try
            {
                var invoiceUpdate = invoiceRepository.GetEntity(Convert.ToInt32(invoiceSaveDto.Id));
                invoiceUpdate.Serie = invoiceSaveDto.Serie;
                invoiceUpdate.RNC = invoiceSaveDto.RNC;
                invoiceUpdate.Expiration_Date = invoiceSaveDto.Expiration_Date;
                invoiceUpdate.Payment_Type = invoiceSaveDto.Payment_Type;
                invoiceUpdate.Client_Id = invoiceSaveDto.Client_Id;
                invoiceUpdate.User_Id = invoiceSaveDto.User_Id;
                invoiceUpdate.Subtotal = invoiceSaveDto.Subtotal;
                invoiceUpdate.Taxes = invoiceSaveDto.Taxes;
                invoiceUpdate.Total = invoiceSaveDto.Total;
                invoiceUpdate.Status = invoiceSaveDto.Status;
                invoiceUpdate.Note = invoiceSaveDto.Note;
                invoiceUpdate.ModifyDate = DateTime.Now;
                invoiceRepository.Update(invoiceUpdate);
                response.Message = "The invoice was succesfully updated";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "There was an error updating the invoice";
                this.logger.LogError($"{response.Message}: {ex.Message}");
                throw;
            }
            return response;
        }
    }
}
        