using System;
using System.ComponentModel.DataAnnotations;
using curriculoapi.Model;

namespace TesteSharepointNovo.Models
{
    public class Curriculo:IEntity
    {

        public int Id { get; set; }

        public int UserId { get; set; }

      
        public string Endereco { get; set; }

        
        public string Nacionalidade { get; set; }

      
        public string Naturalidade { get; set; }

       
        public string EstadoCivil { get; set; }

        public DateTime? DataNascimento { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Resumo { get; set; }

        public string Nome { get; set; }

        public string CargoPretendido { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }
    }
   }