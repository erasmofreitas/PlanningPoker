using Microsoft.AspNetCore.Mvc;
using PlanningPoker.Application.DTO.DTO;
using PlanningPoker.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanningPoker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartasController : ControllerBase
    {
        private readonly ICartasApplication _cartasApplication;

        public CartasController(ICartasApplication cartasApplication)
        {
            _cartasApplication = cartasApplication;
        }
        //GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_cartasApplication.GetAll());
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_cartasApplication.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] CartasDTO cartasDTO)
        {
            try
            {
                if (cartasDTO == null)
                    return NotFound();

                _cartasApplication.Add(cartasDTO);
                return Ok("Carta Cadastrada com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] CartasDTO cartasDTO)
        {
            try
            {
                if (cartasDTO == null)
                    return NotFound();

                _cartasApplication.Update(cartasDTO);
                return Ok("Carta Atualizada com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] CartasDTO cartasDTO)
        {
            try
            {
                if (cartasDTO == null)
                    return NotFound();

                _cartasApplication.Remove(cartasDTO);
                return Ok("Carta Removida com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
