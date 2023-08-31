namespace Dominio.Entities;
    public class Ciudad
    {
        public int IdCiudad { get; set; }        
        public string? NombreCiudad { get; set; }

        public int IdDepFk { get; set; }

        public Departamento? Departamento { get; set; }
        public ICollection<Persona>? Personas { get; set; }
    }
