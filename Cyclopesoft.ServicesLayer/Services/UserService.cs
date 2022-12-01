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
    public class UserService : IUserService

    {
        public readonly IUserRepository userRepository;
        private readonly ILogger<UserRepository> logger;

        public UserService(IUserRepository userRepository, ILogger<UserRepository> logger)
        {
            this.userRepository = userRepository;
            this.logger = logger;
        }
        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var user = userRepository.GetEntities();
               
                result.Data = user.Select(usr => new UserModel()
                {
                   Password = usr.Password,
                   Rol = usr.Rol,
                   Img = usr.Img,
                   Last_Connection = usr.Last_Connection,
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

        public ServiceResult GetById(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var user = userRepository.GetUserById(id);

                result.Data = user.Select(usr => new UserModel()
                {
                    Password = usr.Password,
                    Rol = usr.Rol,
                    Img = usr.Img,
                    Last_Connection = usr.Last_Connection,
                }).ToList();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "There was an error getting the User";
                this.logger.LogError($"{result.Message}: {ex.Message}");
                throw;
            }
            return result;
        }

        public UserResponse RemoveUser(UserRemoveDto userRemoveDto)
        {
            UserRemoveResponse response = new UserRemoveResponse();
            try
            {
                var userDelete = userRepository.GetEntity(Convert.ToInt32(userRemoveDto.Id));
                userDelete.DeleteDate = DateTime.Now;
                userRepository.Remove(userDelete);
                response.Message = "The user was succesfully removed";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "There was an error removing the user";
                this.logger.LogError($"{response.Message}: {ex.Message}");
                throw;
            }
            return response;
        }

        public UserResponse SaveUser(UserSaveDto userSaveDto)
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
                     Password=userSaveDto.Password,
                    Rol = userSaveDto.Rol,
                   Img = userSaveDto.Img,
                     Last_Connection= userSaveDto.Last_Connection,
                    
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

        public UserResponse UpdateUser(UserUpdateDto userSaveDto)
        {
            UserUpdateResponse response = new UserUpdateResponse();
            try
            {
                var userUpdate = userRepository.GetEntity(Convert.ToInt32(userSaveDto.Id));
                userUpdate.ModifyDate = DateTime.Now;
                userRepository.Update(userUpdate);
                response.Message = "The user was succesfully updated";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "There was an error updating the user";
                this.logger.LogError($"{response.Message}: {ex.Message}");
                throw;
            }
            return response;
        }
    }
}
