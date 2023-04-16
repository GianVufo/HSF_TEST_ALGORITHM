using System;
using System.Collections.Generic;
using HSF_Test_Algorithm.Models;

namespace HSF_Test_Algorithm.Services
{
    public class ReceitaServices
    {
        public List<Receita> ListaDeReceitas;

        public ReceitaServices()
        {
            ListaDeReceitas = new List<Receita>();
        }

        public void AdicionarReceita(Receita novaReceita)
        {
            ListaDeReceitas.Add(novaReceita);
        }

        public void Receitas()
        {

            Receita rec = new Receita();
            RemedioServices res = new RemedioServices();

            Console.WriteLine("Nome do Paciente");
            rec.PacientName = Console.ReadLine();

            Console.WriteLine("Nome do Médico");
            rec.MedicName = Console.ReadLine();

            Console.WriteLine("Unidade de Atendimento");
            rec.MedicUnity = Console.ReadLine();

            AdicionarReceita(rec);

        }

        public void ListarReceitas()
        {
            RemedioServices res = new RemedioServices();

            foreach (var item in ListaDeReceitas)
            {
                Console.WriteLine("Nome Do Paciente : " + item.PacientName);
                Console.WriteLine("Nome Do Médico : " + item.MedicName);
                Console.WriteLine("Unidade de atendimento : " + item.MedicUnity);
            }

        }
    }
}