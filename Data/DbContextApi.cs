using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
      public class DbContextApi : DbContext
      {
            public DbContextApi(DbContextOptions<DbContextApi> options) : base(options)
            {
            }
            public DbSet<ApiModel>  ApiModels{ get; set; }


      }
}