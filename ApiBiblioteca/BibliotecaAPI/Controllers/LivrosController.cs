using BibliotecaAPI.Data;
using BibliotecaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly BibliotecaContexto _context;

        public LivrosController(BibliotecaContexto context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Livro>>> Get()
        {
            var livros = await _context.Livros
               .ToListAsync();

            return livros;
        }

        [HttpGet("{id}")]
        public async Task <ActionResult<Livro>> Get(int id)
        {
            var livro = await _context.Livros.FirstOrDefaultAsync(t => t.Id == id);

            if (livro == null)
                return NotFound();

            return livro;
        }

        [HttpPost]
        public async Task<ActionResult<Livro>> Post(Livro livro)
        {
            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = livro.Id }, livro);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Livro livro)
        {
            if (id != livro.Id)
                return BadRequest();

            var livroBanco = await _context.Livros.FindAsync(id);

            if (livroBanco == null)
                return NotFound();

            livroBanco.NomeLivro = livro.NomeLivro;
            livroBanco.Autor= livro.Autor;
            livroBanco.AnoPublicacao = livro.AnoPublicacao;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Livro>> Delete(int id)
        {
            var livro = await _context.Livros.FindAsync(id);
            if (livro == null)
                return NotFound();

            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();

            return livro;
        }

    }
}
