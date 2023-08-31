namespace Dominio.Entities;
    public class TrainerSalon
    {
        public int IdPersonaTrainer { get; set; }

        public Persona? Persona { get; set; }
        public int IdSalonFk { get; set; }
        public Salon? Salon { get; set; }
    }
