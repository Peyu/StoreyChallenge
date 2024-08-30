using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Storey.DAL.Models
{
	public class CategoriaItem
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[JsonIgnore]
		public int CategoriaItemId { get; set; }
		public string Elemento	{ get; set; }
		public int Valor { get; set; }

		[JsonIgnore]
		[ForeignKey("CategoriaId")]
		public int CategoriaId { get; set; }

	}
}
