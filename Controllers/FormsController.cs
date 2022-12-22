using ConvertJsonToForm.Bll;
using ConvertJsonToForm.DAL.Module;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvertJsonToForm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormsController : ControllerBase
    {
        private readonly IBaseRepository<Forms> _Repository;

        public FormsController(IBaseRepository<Forms> Repository)
        {
            _Repository = Repository;
        }

        // GET: api/GetTimes 
        [HttpGet("GetAll")]
        public ActionResult<Forms> GetAll()
        {
            var Forms = _Repository.GetAll();

            if (Forms == null)
            {
                return NotFound();
            }

            return Ok(Forms);
        }
 

        // GET: api/Movies/5
        [HttpGet("{id}")]
        public ActionResult<Forms> GetById(int id)
        {
            var Forms = _Repository.GetById(id);

            if (Forms == null)
            {
                return NotFound();
            }

            return Forms;
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Forms Forms)
        {
            if (id != Forms.Id)
            {
                return BadRequest();
            }

            _Repository.Update(Forms);
            return Ok(true);
        }

        [HttpPost]
        public ActionResult<Forms> Post(Forms Forms)
        {
            _Repository.Add(Forms);
            return Ok(true);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Forms = _Repository.GetById(id);
            if (Forms == null)
            {
                return NotFound();
            }

            _Repository.Delete(Forms);
            return Ok(Forms);
        }


    }
}
