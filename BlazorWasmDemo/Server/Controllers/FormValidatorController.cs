using BlazorWasmDemo.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWasmDemo.Server.Controllers
{
    public class FormValidatorController : Controller
    {
        [HttpPost]
        [Route("/formvalidator")]
        public IActionResult Index([FromBody]FormDto formDto)
        {
            if (formDto.Person.Firstname == "Yasin")
            {
                ThowException(formDto);
            }
            return Ok();
        }

        private void ThowException(FormDto formDtoYasin)
        {
            // This would throw an exception
            //var dbContext = new DbContext();
            //dbContext.Persons.Add(formDtoYasin);
            //dbContext.SaveChanges();
        }
    }
}
