using System.ComponentModel.DataAnnotations;

namespace DejotaTur.Models
{
    public class Destinos
    {
        [Key]
        public int ID_Destino { get; set; }
        [StringLength(70)]
        public string Cidade { get; set; }
        [StringLength(30)]
        public string País { get; set; }
        [StringLength(20)]
        public string Continente { get; set; }
        [StringLength(20)]
        public string Aeroportos_IATA { get; set; }
    }
}
