using System.Collections.Generic;
using api.Models;

namespace api.Data
{
      public interface IApiRepo
      {
            IEnumerable<ApiModel> getApiName();
            ApiModel getApiNameById(int id);
      }
}
