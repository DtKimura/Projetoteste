using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Projetoteste.Models
{
    [Table("Consumos")]
    public class consumos
    {
        [Key]
        public int Id {  get; set; }

        [Required(ErrorMessage ="Obrigatório informar a descrição")]
        public String descricao { get; set; }

        [Required(ErrorMessage ="Obrigatório informar a data")]
        public DateTime data { get; set; }

        [Required(ErrorMessage ="Obrigatório informar valor")]
        public decimal Valor {  get; set; }

        [Required(ErrorMessage ="Obrigatório informar quilometragem")]
        public int Km {  get; set; }

        public TipoCombustivel Tipo {  get; set; }

        public int VeiculiId {  get; set; }
        [ForeignKey("VeiculoId")]
        public Veículo Veiculo { get; set; }


    }
    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }

}
