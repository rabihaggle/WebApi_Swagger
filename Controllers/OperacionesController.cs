using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApi1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : ControllerBase
    {
        private readonly PRE_ALTIUS_00_INTERMEDIAContext _context;

        public OperacionesController(PRE_ALTIUS_00_INTERMEDIAContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Models._00Operacione> Get()
        {


            IEnumerable<Models._00Operacione> op = _context._00Operaciones.ToList();
            return op;


        }

        [HttpGet("getContenedores", Name = "getContenedores")]
        public IEnumerable<Models.OperacionesAProcesar> getContenedores()
        {

            IEnumerable<Models.OperacionesAProcesar> op = _context.OperacionesAProcesars
                .ToList();

            return op;


        }

        [HttpGet("getContenedoresdist", Name = "getContenedoresdist")]
        public IEnumerable<Models.DistinctOpContainerNav> getContenedoresdist()
        {

            IEnumerable<Models.DistinctOpContainerNav> op = _context.DistinctOpContainerNavs
                .ToList();

            return op;


        }

    }
}
