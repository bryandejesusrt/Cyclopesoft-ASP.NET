using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.DataLayer.Interface;
using Cyclopesoft.DataLayer.Repository;
using Cyclopesoft.ServicesLayer.Contracts;
using Cyclopesoft.ServicesLayer.Core;
using Cyclopesoft.ServicesLayer.Dtos;
using Cyclopesoft.ServicesLayer.Responses;
using Microsoft.Data.SqlClient;
using System.Linq;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Cyclopesoft.ServicesLayer.Models;
using Cyclopesoft.ServicesLayer.Validations;

namespace Cyclopesoft.ServicesLayer.Services
{
    public class ClientService : IClientService
    {
        public readonly IClientRepository clientRepository;
        private readonly ILogger<ClientRepository> logger;

        public ClientService(IClientRepository ClientRepository, ILogger<ClientRepository> logger)
        {
            this.clientRepository = ClientRepository;
            this.logger = logger;
        }
        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var client = clientRepository.GetEntities();

                result.Data = client.Select(cn => new ClientModel()
                {
                    Id = cn.Id,
                    Name = cn.Name,
                    LastName = cn.LastName,
                    Email = cn.Email,
                    Phone = cn.Phone,

                }).ToList();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "There was an error getting the client";
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
                var client = clientRepository.GetClientById(id);

                result.Data = client.Select(cn => new ClientModel()
                {
                    Id = cn.Id,
                    Name = cn.Name,
                    LastName = cn.LastName,
                    Email = cn.Email,
                    Phone = cn.Phone,

                }).ToList();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "There was an error getting the client";
                this.logger.LogError($"{result.Message}: {ex.Message}");
                throw;
            }
            return result;
        }

        public ClientResponse RemoveClient(ClientRemoveDto clientRemoveDto)
        {
            ClientResponse response = new ClientResponse();
            try
            {
                var clientdelete = clientRepository.GetEntity(Convert.ToInt32(clientRemoveDto.Id));
                clientdelete.DeleteDate = DateTime.Now;
                clientRepository.Remove(clientdelete);
                response.Message = "The user was succesfully removed";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "There was an error removing the client";
                this.logger.LogError($"{response.Message}: {ex.Message}");
                throw;
            }
            return response;
        }

        public ClientResponse SaveClient(ClientSaveDto clientSaveDto)
        {
            UserSaveResponse response = new UserSaveResponse();
            try
            {
                var isClientValid = ClientValidation.AssertClientIsValid(clientSaveDto);

                if (!isClientValid.Success)
                {
                    response.Success = isClientValid.Success;
                    response.Message = isClientValid.Message;
                    return response;
                }
                if (clientRepository.Exists(inv => inv.Id == clientSaveDto.Id))
                {
                    response.Success = false;
                    response.Message = "This user was already registered";
                    return response;
                }

                var userSave = new User()
                {
                    Password = clie.Password,
                    Rol = userSaveDto.Rol,
                    Img = userSaveDto.Img,
                    Last_Connection = userSaveDto.Last_Connection,

                };
                userRepository.Save(userSave);
                response.Message = "The user was saved succesfully";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "There was an error saving the user";
                this.logger.LogError($"{response.Message}: {ex.Message}");
                throw;
            }
            return response;

            public ClientResponse UpdateClient(ClientUpdateDto clientUpdateDto)
            {
                UserSaveResponse response = new UserSaveResponse();
                try
                {
                    var isValidUser = UserValidations.AssertUserIsValid(userSaveDto);

                    if (!isValidUser.Success)
                    {
                        response.Success = isValidUser.Success;
                        response.Message = isValidUser.Message;
                        return response;
                    }
                    if (userRepository.Exists(inv => inv.Id == userSaveDto.Id))
                    {
                        response.Success = false;
                        response.Message = "This user was already registered";
                        return response;
                    }

                    var userSave = new User()
                    {
                        Password = userSaveDto.Password,
                        Rol = userSaveDto.Rol,
                        Img = userSaveDto.Img,
                        Last_Connection = userSaveDto.Last_Connection,

                    };
                    userRepository.Save(userSave);
                    response.Message = "The user was saved succesfully";
                }
                catch (Exception ex)
                {
                    response.Success = false;
                    response.Message = "There was an error saving the user";
                    this.logger.LogError($"{response.Message}: {ex.Message}");
                    throw;
                }
                return response;
            }
        }
    }
}
