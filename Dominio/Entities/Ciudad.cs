namespace Dominio.Entities;
    public class Ciudad
    {
        public int IdCiudad { get; set; }        
        public string? NombreCiudad { get; set; }

        public int IdDepFk { get; set; }
    }
