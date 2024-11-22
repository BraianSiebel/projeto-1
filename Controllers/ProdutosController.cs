using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("controller}")]

public class ProdutosController : ControllerBase
{
    private readonly AppDbContext _context;
    public ProdutosController(AppDbContext context)
    {
        _context = context;
    }
    private static List<Produto> produtos = new List<Produto>();

    public ActionResult<List<Produto>> GetAll()
    {
        return _context.Produtos.ToList();
    }

    [HttpGet]
  
    [HttpGet ("{id}")]
    public ActionResult<Produto> GetById(int id)
    {
    

        var produtoEncontrado = _context.Produtos.Find(id);

        if(produtoEncontrado == null)
        
            return NotFound();
        return produtoEncontrado;
    }
    [HttpPost]
    public ActionResult Post(Produto produto)
    {
        _context.Produtos.Add(produto);
        _context.SaveChanges();
        return Created();
    }
    [HttpPut("{id}")]
    public ActionResult Put(int id, Produto produtoAtualizado)
    {
       var produtoEncontrado = _context.Produtos.Find(id);
       
        if(produtoEncontrado == null)
        {
            return NotFound();
        }
        produtoEncontrado.Nome = produtoAtualizado.Nome;
        produtoEncontrado.Preco = produtoEncontrado.Preco;

        _context.SaveChanges();

        return NoContent();
        
        
    }
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var produtoEncontrado = _context.Produtos.Find(id);
    
        if(produtoEncontrado == null)
            {
                return NotFound();
            }
            produtos.Remove(produtoEncontrado);
            return NoContent();
        _context.Produtos.Remove(produtoEncontrado);
        _context.SaveChanges();
        return NoContent();
    }
    
}

