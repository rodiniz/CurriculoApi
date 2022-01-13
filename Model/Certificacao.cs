using System.ComponentModel.DataAnnotations;
using TesteSharepointNovo.Models;

namespace curriculoapi.Model
{
    public class Certificacao:IEntity
    {
        [Key]

        public int Id { get; set; }

        public string Nome { get; set; }

        public int ObtidaEm { get; set; }


        public byte[] Logo { get; set; }

        public virtual Curriculo Curriculo { get; set; }
    }
}
