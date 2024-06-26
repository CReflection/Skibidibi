﻿using Microsoft.AspNetCore.Mvc;

namespace Skibidibi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SkibidiController : ControllerBase
    {
        
        private readonly ISkibidiService _service;
        private readonly ILogger<SkibidiController> _logger;

        public SkibidiController(ILogger<SkibidiController> logger, ISkibidiService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("GetSkibidies")]
        public ActionResult<IEnumerable<Skibidi>> GetAll()
        {
            var result = _service.GetAll();
            return Ok(result);
        }

        [HttpGet("{index}")]
        public ActionResult<Skibidi> Get(int index) 
        {
            var result = _service.Get(index);
            if(result == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(result);
            }
            
        }
        /// <summary>
        /// endpoint dodający skibidi
        /// </summary>
        /// <param name="skibidi"></param>
        /// <returns></returns>
        [HttpPost("Add")]
        public ActionResult Add([FromBody] Skibidi skibidi)
        {
            var result = _service.Add(skibidi);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public ActionResult Delete(int index)
        {
            var result = _service.Delete(index);
            if (!result)
            {
              
                return NotFound();
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("SumStrength")]
        public ActionResult<int> SumTheStrongest()
        {
            var result = _service.SumTheStrongest();
            return Ok(result);
        }


    }
}