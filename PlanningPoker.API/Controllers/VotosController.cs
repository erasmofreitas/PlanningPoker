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
    public class VotosController : ControllerBase
    {
        private readonly IVotosApplication _VotosApplication;

        public VotosController(IVotosApplication VotosApplication)
        {
            _VotosApplication = VotosApplication;
        }
        //GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_VotosApplication.GetAll());
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_VotosApplication.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] VotosDTO VotosDTO)
        {
            try
            {
                if (VotosDTO == null)
                    return NotFound();

                _VotosApplication.Add(VotosDTO);
                return Ok("Voto Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] VotosDTO VotosDTO)
        {
            try
            {
                if (VotosDTO == null)
                    return NotFound();

                _VotosApplication.Update(VotosDTO);
                return Ok("Voto Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] VotosDTO VotosDTO)
        {
            try
            {
                if (VotosDTO == null)
                    return NotFound();

                _VotosApplication.Remove(VotosDTO);
                return Ok("Voto Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
