using System;
using HSF_Test_Algorithm.Models;
using HSF_Test_Algorithm.Services;

namespace HSF_Test_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            ReceitaServices recs = new ReceitaServices();
            RemedioServices rems = new RemedioServices();

            Console.WriteLine("Olá, vamos criar o seu receituário.");
            Console.WriteLine("Comece adicionando os dados obrigatórios do Receituário : ");
            recs.Receitas();

            Console.WriteLine("Agora adicione os Medicamentos à receitar : ");
            rems.Remedios();

            Console.WriteLine("Receita Pronta ! Veja o Reultado");

            recs.ListarReceitas();
            rems.ListarRemedios();

        }
    }
}
