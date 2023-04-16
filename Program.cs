using System;
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
            Console.WriteLine("Comece adicionando os dados iniciais : ");
            recs.Receitas();

            Console.WriteLine("Agora adicione os Medicamentos : ");
            rems.Remedios();

            Console.WriteLine("Receita Pronta ! Veja o Reultado");

            recs.ListarReceitas();

            rems.ListarRemedios();

        }
    }
}
