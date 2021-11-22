using System.ComponentModel.DataAnnotations;
using TesteSharepointNovo.Models;

namespace curriculoapi.Model
{
    public class Formacao
    {
        [Key]

        public int Id { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public Curriculo Curriculo { get; set; }

        [Display(Name = "Nome da Formação ")]
        public string NomeFormacao { get; set; }

        [Display(Name = "Local")]
        public string Local { get; set; }

        public int AnoInicio { get; set; }

        public int AnoFinal { get; set; }

    }

}
