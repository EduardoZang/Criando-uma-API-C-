using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmesApi.Models{

    public class Filme
    {

        [Key]
        [Required]
         public int Id { get; set; }
         
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O título do filme não pode exceder 50 caracteres")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O campo de duração é obrigatório")]
    [Range(1, 360, ErrorMessage = "A duração deve ter no mínimo 1 minuto e no máximo 360")]
    public int Duracao { get; set; }
    public string Diretor { get; set; }

     [Required]
    public string Genero { get; set; }   

    [Required]
    [Column("produtoraId")]
        public int produtoraId { get; set; }
        public Produtora produtora { get; set; }    
    }
}
