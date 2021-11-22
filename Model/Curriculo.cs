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

    public class Certificacao
    {
        [Key]

        public int Id { get; set; }

        public string Nome { get; set; }

        public int ObtidaEm { get; set; }


        public byte[] Logo { get; set; }

        public Curriculo Curriculo { get; set; }
    }

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

    public class Tecnologia
    {
        [Key]

        public int Id { get; set; }

        public string NomeTecnologia { get; set; }

        public int AutoAvaliacao { get; set; }

        public Curriculo Curriculo { get; set; }

    }

}