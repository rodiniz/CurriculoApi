using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using curriculoapi.Model;

namespace TesteSharepointNovo.Models
{
    public class Lingua:IEntity
    {
        [Key]
      
        public int Id { get; set; }

        [Display(Name = "Língua")]
        public string Descricao { get; set; }

        public string Fluencia { get; set; }

        public Curriculo Curriculo { get; set; }
    }
}