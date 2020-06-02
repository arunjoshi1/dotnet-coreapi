using api.Data;
using api.Dtos;
using api.Models;
using api.Profiles;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace api.Controllers
{
    [ApiController]
    [Route("api/data")]
    public class ApiController : ControllerBase
    {
        private readonly IApiRepo _repo;
        private readonly IMapper _mapper;

        public ApiController(IApiRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // private readonly MockApiRepo _repo = new MockApiRepo();
        [HttpGet]
        public ActionResult<IEnumerable<ApiModel>> GetAllData()
        {
            var data = _repo.getApiName();
            var d = _mapper.Map<ApiDto>(data);
            
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