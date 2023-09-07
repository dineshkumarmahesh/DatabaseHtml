using EF_Library.EfRepository;
using EFwebLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebApiController : ControllerBase
    {
        private readonly IStudendRepository _Repository;
        
        public WebApiController(IStudendRepository rep)
        {
            _Repository= rep;
        }

        // GET: api/<WebApiController>
        [HttpGet]
        public IEnumerable<EFmodel> Get()
        {
            return _Repository.GetAllRegistration();
        }

        // GET api/<WebApiController>/5
        [HttpGet("{empId}")]
        public EFmodel Get(int empId)
        {
            return _Repository.GetRegistrationById(empId);
        }

        // POST api/<WebApiController>
        [HttpPost]
        public void Post([FromBody] EFmodel data)
        {
            try {
                _Repository.Insert(data);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        // PUT api/<WebApiController>/5
        [HttpPut("{Empid}")]
        public void Put(int Empid, [FromBody] EFmodel value)
        {
            try {
                value.Empid = Empid;
                _Repository.Update(value);
            }
            catch(Exception ex)
            {
                throw;
            }
        
        }

        // DELETE api/<WebApiController>/5
        [HttpDelete("{Empid}")]
        public void Delete(int Empid)
        {
            _Repository.Delete(Empid);
        }
    }
}
