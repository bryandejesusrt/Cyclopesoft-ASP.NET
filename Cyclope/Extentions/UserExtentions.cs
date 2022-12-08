using Cyclopesoft.ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cyclope.Extentions
{
    public static class UserExtentions
    {
        public static IEnumerable<Cyclopesoft.Model.User> ConvertUserModelToModel(this List<UserModel> userModels)
        {
            var users = userModels.Select(usr => new Cyclopesoft.Model.User()
            {
                Password = usr.Password,
                Rol = usr.Rol,
                Img = usr.Img,
                Creation_Date = usr.Creation_Date,
                Last_Connection = usr.Last_Connection,

            }).ToList();

            return users;
        }
    }
}
