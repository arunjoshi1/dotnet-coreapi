using api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Data
{
    public class SqlApiData:IApiRepo
    {
        private readonly DbContextApi _context;

        public SqlApiData(DbContextApi context)
        {
            _context = context;

        }

        public IEnumerable<ApiModel> getApiName()
        {
            return _context.ApiModels.ToList();
        }

        public ApiModel getApiNameById(int id)
        {
            return _context.ApiModels.FirstOrDefault(d=>d.Id==id);

        }
    }
}
