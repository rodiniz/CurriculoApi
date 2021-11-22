using System.ComponentModel.DataAnnotations;
using TesteSharepointNovo.Models;

namespace curriculoapi.Model
{
    public class Tecnologia
    {
        [Key]

        public int Id { get; set; }

        public string NomeTecnologia { get; set; }

        public int AutoAvaliacao { get; set; }

        public Curriculo Curriculo { get; set; }

    }
}
