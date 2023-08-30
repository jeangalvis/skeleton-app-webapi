namespace Dominio.Entities;
    public class Persona
    {
        public int IdPersona { get; set; }
        public string? NombrePersona { get; set; }

        public int IdGeneroFk { get; set; }

        public int IdCiudadFk { get; set; }
        public int IdTipoPerFk { get; set; }
    }
