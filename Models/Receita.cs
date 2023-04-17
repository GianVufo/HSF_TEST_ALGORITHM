using System.Collections.Generic;

namespace HSF_Test_Algorithm.Models
{
    public class Receita
    {

        public string MedicName { get; set; }
        public string PacientName { get; set; }
        public string MedicUnity { get; set; }
        public Remedio Remedio { get; set; }
        public List<Remedio> Medicamentos = new List<Remedio>();

    }

}