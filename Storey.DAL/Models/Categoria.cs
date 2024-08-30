using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Storey.DAL.Models
{
	public class Categoria
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[JsonIgnore]
		public int CategoriaId { get; set; }
		
		[JsonPropertyName("Categoria")]
		public string Nombre { get; set; }
		public virtual ICollection<CategoriaItem> Items { get; set; }
	}
}
