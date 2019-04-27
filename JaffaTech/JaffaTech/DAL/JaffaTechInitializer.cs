using JaffaTech.Models;
using JaffaTech.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JaffaTech.DAL
{
    public class JaffaTechInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<JaffaTechDbContext>
    {
        protected override void Seed(JaffaTechDbContext context)
        {
            List<User> user = new List<User> { new User
            { Username = "olasimaduka.jaffatech.com", Password = "maduka" },
                new User {Username = "olasimaduka.jaffatech.com", Password = "maduka" }
            };

            user.ForEach(usr => context.User.Add(usr));
            context.SaveChanges();

            List<Role> Role = new List<Role> { new Role{ RoleName = "admin"},
                new Role{RoleName = "HR"}
            };

            Role.ForEach(rl => context.Role.Add(rl));
            context.SaveChanges();

            List<UserRole> userRoles = new List<UserRole> { new UserRole { UserId = 2, RoleId = 1 }, new UserRole { UserId = 1, RoleId = 2 } };
            userRoles.ForEach(usrl => context.UserRole.Add(usrl));
            context.SaveChanges();

            //base.Seed(context);
        }
    }
}