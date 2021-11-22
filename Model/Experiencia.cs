using System.ComponentModel.DataAnnotations;
using TesteSharepointNovo.Models;

namespace curriculoapi.Model
{
    public class Experiencia
    {
        [Key]

        public int Id { get; set; }

        public string NomeEmpresa { get; set; }

        [Display(Name = "Ano de início ")]
        public int AnoInicio { get; set; }

        [Display(Name = "Mês de início ")]
        public int MesInicio { get; set; }

        [Display(Name = "Ano de término ")]
        public int AnoFinal { get; set; }

        [Display(Name = "Mês de Término ")]
        public int MesFinal { get; set; }

        public string Atividades { get; set; }

        public Curriculo Curriculo { get; set; }

        public string Cargo { get; set; }

        public bool Atual { get; set; }
    }
}
