using System;
using System.ComponentModel.DataAnnotations;

namespace TesteSharepointNovo.Models
{
    public class Curriculo
    {

        public int Id { get; set; }

        public int UserId { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Preencha a nacionalidade")]
        public string Nacionalidade { get; set; }

        [Required(ErrorMessage = "Preencha a naturalidade")]
        public string Naturalidade { get; set; }

        [Required(ErrorMessage = "Preencha o estado civil")]
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