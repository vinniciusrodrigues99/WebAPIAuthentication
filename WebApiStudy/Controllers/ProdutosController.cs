using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiStudy.Context;
using WebApiStudy.Domain;

namespace WebApiStudy.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutosController: ControllerBase
{
    private readonly AppDbContext _context;

    public ProdutosController(AppDbContext context)
    {
        _context = context;
    }
    [HttpGet(Name = "GetAll")]
    public async Task<List<Produto>> GetAllAsync()
    {
        var produtos = await _context.Produtos.AsNoTracking().ToListAsync();
        return produtos;
    }
}