using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APICrudCeuta.Model;
using APICrudCeuta.Object;
using APICrudCeuta.Data;

namespace APICrudCeuta.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        ValuesData data = new ValuesData();
        // GET api/values
        [HttpGet("{visita.Nombre}&{visita.Departamento}&{visita.Persona}&{visita.IP}&{visita.Horas}&")]
        public string GuardarDatos([FromRoute] VisitasModel visita)
        {
            return data.GuardarDatosPersona(visita.Nombre, visita.Departamento, visita.Persona, visita.IP, visita.Horas);
        }

        [HttpGet("[action]/{nombre}&{ip}&")]
        public string ModificarIP(string nombre, string ip)
        {
            return data.ModificarIP(nombre, ip);
        }

        /*[HttpPost("[action]")]
        public async Task<IActionResult> Crear([FromBody] Datos_Model model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Usuario usuario = new Usuario
            {
                Nombre = model.Nombre,
                Departamento = model.Departamento,
                Persona = model.Persona,
                IP = model.IP
            };

            _context.Categorias.Add(categoria);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok();
        }
        */
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
