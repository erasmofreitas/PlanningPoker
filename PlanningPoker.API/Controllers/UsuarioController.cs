using Microsoft.AspNetCore.Mvc;
using PlanningPoker.Application.DTO;
using PlanningPoker.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanningPoker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuariosApplication _UsuariosApplication;

        public UsuarioController(IUsuariosApplication UsuariosApplication)
        {
            _UsuariosApplication = UsuariosApplication;
        }
        //GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_UsuariosApplication.GetAll());
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_UsuariosApplication.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] UsuariosDTO UsuariosDTO)
        {
            try
            {
                if (UsuariosDTO == null)
                    return NotFound();

                _UsuariosApplication.Add(UsuariosDTO);
                return Ok("Usuário Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] UsuariosDTO UsuariosDTO)
        {
            try
            {
                if (UsuariosDTO == null)
                    return NotFound();

                _UsuariosApplication.Update(UsuariosDTO);
                return Ok("Usuário Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] UsuariosDTO UsuariosDTO)
        {
            try
            {
                if (UsuariosDTO == null)
                    return NotFound();

                _UsuariosApplication.Remove(UsuariosDTO);
                return Ok("Usuário Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
