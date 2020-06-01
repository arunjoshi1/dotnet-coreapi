
using System;
using System.Collections.Generic;
using api.Data;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
      [ApiController]
      [Route("api/data")]
      public class ApiController : ControllerBase
      {
            private readonly IApiRepo _repo;

            public ApiController(IApiRepo repo)
            {
                  _repo = repo;
            }
            // private readonly MockApiRepo _repo = new MockApiRepo();
            [HttpGet]
            public ActionResult<IEnumerable<ApiModel>> GetAllData()
            {
                  var data = _repo.getApiName();
                  return Ok(data);
            }
            [HttpGet("{id}")]
            public ActionResult<ApiModel> GetDataById(int id)
            {
                  var data = _repo.getApiNameById(id);
                  return Ok(data);
            }
      }
}