namespace Dominio.Entities;
    public class Departamento
    {
        public int IdDep { get; set; }
        public string? NombreDep { get; set; }
        public int IdPaisFk { get; set; }

        public Pais? Pais { get; set; }
        public ICollection<Ciudad>? Ciudades { get; set; }
    }
