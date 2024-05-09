using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projetoteste.Models
{
    [Table("Veículos")]
    public class Veículo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Obrigatório informar a placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o ano de fabricação")]
        [Display(Name = "Ano de fabricação")]
        public int AnoFabricacao { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar o ano")]
        [Display(Name = "Ano do modelo")]
        public int AnoModelo { get; set; }

        public ICollection<consumos> Consumos { get; set; } 
    }
}
