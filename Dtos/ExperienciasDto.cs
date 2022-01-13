namespace curriculoapi.Dtos
{
    //Data transfer object mirroring the experiencia class    
    public class ExperienciasDto
    {
        public int Id { get; set; }

        public string NomeEmpresa { get; set; }

       
        public int AnoInicio { get; set; }

        
        public int MesInicio { get; set; }

        
        public int AnoFinal { get; set; }

       
        public int MesFinal { get; set; }

        public string Atividades { get; set; }

        public int  IdCurriculo { get; set; }

        public string Cargo { get; set; }

        public bool Atual { get; set; }

    }
}