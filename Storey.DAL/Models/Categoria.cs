using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storey.DAL.Models
{
	public class Categoria
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CategoriaId { get; set; }
		public string Nombre { get; set; }
		public virtual ICollection<CategoriaItem> Items { get; set; }
	}
}
