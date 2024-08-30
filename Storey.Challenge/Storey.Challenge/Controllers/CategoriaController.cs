using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Storey.DAL;

namespace Storey.Challenge.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriaController : ControllerBase
	{

		private StoreyContext _context;

		public CategoriaController(StoreyContext context)
		{
			_context = context;
		}


		[HttpGet("")]
		public async Task<IActionResult> GetCategorias()
		{
			try
			{

				var result = await _context.Categorias
					.Include(c => c.Items)
					.ToListAsync();

				return Ok(result);

			}
			catch (Exception ex) {
				Console.WriteLine(ex.Message);

				return BadRequest(ex.Message);
			}

		}

	}
}
