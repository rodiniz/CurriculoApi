using System.ComponentModel.DataAnnotations;
using TesteSharepointNovo.Models;

namespace curriculoapi.Model
{
    public class Certificacao
    {
        [Key]

        public int Id { get; set; }

        public string Nome { get; set; }

        public int ObtidaEm { get; set; }


        public byte[] Logo { get; set; }

        public Curriculo Curriculo { get; set; }
    }
}
