using ApiWeb.Data;
using ApiWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ApiWeb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutoController(AppDbContext context) : ControllerBase
{
	private readonly AppDbContext _context = context;

	[HttpGet]
	public ActionResult<List<ProdutoModel>> BuscarProdutos()
	{
		var produtos = _context.Produtos.ToList();
		return Ok(produtos);
	}

	[HttpGet("{id}")]
	public ActionResult<ProdutoModel> BuscarProdutoPorId(int id)
	{
		var produto = _context.Produtos.FirstOrDefault(x => x.Id == id);
		return produto == null ? NotFound() : Ok(produto);
	}

	[HttpPost]
	public ActionResult<ProdutoModel> AdicionarProduto(ProdutoModel produto)
	{

		if (produto == null)
			return BadRequest("O produto não pode ser nulo");

		_context.Produtos.Add(produto);
		_context.SaveChanges();
		return CreatedAtAction(nameof(BuscarProdutoPorId), new { id = produto.Id }, produto);
	}

	[HttpPut("{id}")]
	public ActionResult AtualizarProduto(int id, ProdutoModel produtoModel )
	{
		var produto = _context.Produtos.Find(id);
		if (produto == null)
			return NotFound();

		produto.Nome = produtoModel.Nome;
		produto.Descricao = produtoModel.Descricao;
		produto.QuantidadeEstoque = produtoModel.QuantidadeEstoque;
		produto.CodigoDeBarras = produtoModel.CodigoDeBarras;
		produto.Marca = produtoModel.Marca;

		_context.Produtos.Update(produto);
		_context.SaveChanges();
		return NoContent();
	}

	[HttpDelete("{id}")]
	public ActionResult DeletarProduto(int id)
	{
		var produto = _context.Produtos.Find(id);
		if (produto == null)
			return NotFound();
		_context.Produtos.Remove(produto);
		_context.SaveChanges();
		return NoContent();
	}
}
