using Challenge.Storey.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Storey.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriasController : ControllerBase
	{
		[HttpGet("items")]
		public async Task<IActionResult> GetItems()
		{

			using (var context = new StoreyContext())
			{
				foreach (var categoria in context.Categorias.ToList())
				{
					Console.WriteLine(categoria.CategoriaId);
				}
			}

			return Ok();
		}
	}
}
