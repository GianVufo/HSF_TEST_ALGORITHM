using System;
using System.Collections.Generic;
using HSF_Test_Algorithm.Models;

namespace HSF_Test_Algorithm.Services
{
    public class RemedioServices
    {
        public List<Remedio> ListaDeRemedios;

        public RemedioServices()
        {
            ListaDeRemedios = new List<Remedio>();
        }

        public void AdicionarRemedio(Remedio novoRemedio)
        {
            ListaDeRemedios.Add(novoRemedio);
        }

        public void Remedios()
        {
            char decision = 's';

            do
            {

                Remedio re = new Remedio();
                Receita rec = new Receita();

                Console.WriteLine("Nome do Medicamento : ");
                re.MedicationName = Console.ReadLine();

                Console.WriteLine("Dosagem do Medicamento : ");
                re.MedicationDosage = Console.ReadLine();

                Console.WriteLine("Tipo de uso do Medicamento : ");
                re.MedicationUse = Console.ReadLine();

                AdicionarRemedio(re);

                Console.WriteLine("Deseja adicionar mais remédios à receita?");
                decision = char.Parse(Console.ReadLine());

            } while (decision == 's' || decision == 'S');

        }

        public void ListarRemedios()
        {
            Console.WriteLine("[MEDICAMENTOS INSERIDOS]");

            foreach (var item in ListaDeRemedios)
            {
                Console.WriteLine("Nome do Medicamento : " + item.MedicationName);
                Console.WriteLine("Dosagem do Medicamento : " + item.MedicationDosage);
                Console.WriteLine("Tipo de uso do Medicamento : " + item.MedicationUse);
            }

        }
    }
}