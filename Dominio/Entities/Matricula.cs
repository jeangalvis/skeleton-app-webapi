namespace Dominio.Entities;
    public class Matricula
    {
        public int IdMatricula { get; set; }
        public int IdPersonaFk { get; set; }
        public int IdSalonFk { get; set; }
    }
