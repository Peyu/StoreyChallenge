using Microsoft.EntityFrameworkCore;
using Storey.DAL.Models;

namespace Storey.DAL
{
	public class StoreyContext : DbContext
	{
		public StoreyContext( DbContextOptions<StoreyContext> options)
			: base(options)
		{

		}

		public DbSet<CategoriaItem> Items { get; set; }
		public DbSet<Categoria> Categorias { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Categoria>().ToTable("Categoria");
			modelBuilder.Entity<CategoriaItem>().ToTable("Item");

			// Seed de Categorias
			modelBuilder.Entity<Categoria>().HasData(
				new Categoria { CategoriaId = 1, Nombre = "Iluminación" },
				new Categoria { CategoriaId = 2, Nombre = "Refrigeración" }
			);

			// Seed de CategoriaItems
			modelBuilder.Entity<CategoriaItem>().HasData(
				new CategoriaItem { CategoriaItemId = 1, Elemento = "Lámpara Led de 5w", Valor = 5, CategoriaId = 1  },
				new CategoriaItem { CategoriaItemId = 2, Elemento = "Lámpara Led de 10w", Valor = 10, CategoriaId = 1 },
				new CategoriaItem { CategoriaItemId = 3, Elemento = "Lámpara Incandescente de 40w", Valor = 40, CategoriaId = 1 },
				new CategoriaItem { CategoriaItemId = 4, Elemento = "Lámpara Incandescente de 100w", Valor = 100, CategoriaId = 1 },
				new CategoriaItem { CategoriaItemId = 5, Elemento = "Lámpara Incandescente de 400w", Valor = 400, CategoriaId = 1 },
				new CategoriaItem { CategoriaItemId = 6, Elemento = "Heladera", Valor = 1000, CategoriaId = 2 },
				new CategoriaItem { CategoriaItemId = 7, Elemento = "Freezer", Valor = 1500, CategoriaId = 2 }
			);

		}
				

	}
}
