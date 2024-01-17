namespace HealthyPet.API.Models
{
    public class VetConsult
    {
        public int VetConsultId { get; set; }

        public string Local { get; set; }

        public string VetConsultDate { get; set; }

        public string Type { get; set; }

        public string Veterinarian { get; set; }

        public string Phone { get; set; }

        public string ProfilePhoto { get; set; }
    }
}