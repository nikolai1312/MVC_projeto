using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_projeto.Models
{
    [Table("band")]
    public class BandModel
    {
        [Column("id")]
        public int Id { get; set;}

        [Column("name")]
        
        [Required(ErrorMessage = "Digite o nome da banda")]
        public string BandName { get; set; }

        [Column("genre")]

        [Required(ErrorMessage = "Digite o gênero da banda")]
        
        public string BandGenre { get; set; }

        [Column("year")]

        [Required(ErrorMessage = "Digite o ano da banda")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "O campo deve ter 4 caracteres")]
        public string BandYear { get; set; }
    }
}
