using System;
using Microsoft.AspNet.Identity.EntityFramework;
using XamarinAzure.Backend.Data.Entities;

namespace XamarinAzure.Backend.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}