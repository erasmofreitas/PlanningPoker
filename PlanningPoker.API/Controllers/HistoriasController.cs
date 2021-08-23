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
    public class HistoriasController : ControllerBase
    {
        private readonly IHistoriasApplication _HistoriasApplication;

        public HistoriasController(IHistoriasApplication HistoriasApplication)
        {
            _HistoriasApplication = HistoriasApplication;
        }
        //GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_HistoriasApplication.GetAll());
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_HistoriasApplication.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] HistoriasDTO HistoriasDTO)
        {
            try
            {
                if (HistoriasDTO == null)
                    return NotFound();

                _HistoriasApplication.Add(HistoriasDTO);
                return Ok("História Cadastrada com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] HistoriasDTO HistoriasDTO)
        {
            try
            {
                if (HistoriasDTO == null)
                    return NotFound();

                _HistoriasApplication.Update(HistoriasDTO);
                return Ok("História Atualizada com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] HistoriasDTO HistoriasDTO)
        {
            try
            {
                if (HistoriasDTO == null)
                    return NotFound();

                _HistoriasApplication.Remove(HistoriasDTO);
                return Ok("História Removida com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
