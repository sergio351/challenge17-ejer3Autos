using Challenge17_Ejer3.Entity;
using Challenge17_Ejer3.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Challenge17_Ejer3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public ClienteController(IUnitOfWork context)
        {
            _context = context;
        }
        /// <summary>
        /// Mostrar todos los clientes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            var entidad = _context.ClienteRepo.GetAll();
            return  Ok(entidad);
        }
        /// <summary>
        /// Crear nuevo cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] Cliente cliente)
        {
            _context.ClienteRepo.Insert(cliente);
            _context.Save();
            return Ok();
        }

        /// <summary>
        /// Modificar cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Cliente cliente, int id)
        {
            try
            {
                _context.ClienteRepo.Update(cliente);
                _context.Save();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Eliminar cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var entity = _context.ClienteRepo.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            _context.ClienteRepo.Delete(id);
            _context.Save();

            return Ok();
        }
    }
}

