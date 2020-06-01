using System.Collections.Generic;
using api.Models;

namespace api.Data
{
      public class MockApiRepo : IApiRepo
      {
            public IEnumerable<ApiModel> getApiName()
            {
                  var objects = new List<ApiModel>{
                    new ApiModel {
                        Id = 0,
                        HowTo = "how to boil an egg",
                        Line = "1l water ",
                        plateform = "pan"
                  },
                    new ApiModel {
                        Id = 1,
                        HowTo = "how to boil an egg",
                        Line = "1l water ",
                        plateform = "pan"
                  },
            };
                  return objects;
            }
            public ApiModel getApiNameById(int id)
            {
                  return new ApiModel
                  {
                        Id = id,
                        HowTo = "how to boil an egg",
                        Line = "1l water ",
                        plateform = "pan"
                  };
            
            }

           
      }
}