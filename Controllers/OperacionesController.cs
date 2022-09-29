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
        public IEnumerable<Models._00Operacione> getContenedores()
        {
           
            IEnumerable<Models._00Operacione> op = _context._00Operaciones
                .Where(b => !b.CodMatriculaContenedor.Contains("-")).ToList();
            return op;


        }

    }
}
