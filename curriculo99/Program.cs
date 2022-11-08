using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curriculo99
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            int Idade;
            string Endereço;
            string Cidade;
            int Tell;
            string Objetivos;
            string Formações;
            string Experiencias;

            Console.WriteLine("CADASTRE O SEU CURRÍCULO");
            Console.WriteLine("DIGITE SEU NOME COMPLETO:");
        Nome: Console.ReadLine();
            Console.WriteLine("DIGITE SUA IDADE:");
        Idade: Console.ReadLine();
            Console.WriteLine("DIGITE SEU ENDEREÇO:");
        Endereço: Console.ReadLine();
            Console.WriteLine("DIGITE SUA CIDADE:");
        Cidade: Console.ReadLine();
            Console.WriteLine("DIGITE SEU TELEFONE/CELULAR:");
        Tell: Console.ReadLine();
            Console.WriteLine("DIGITE SEUS OBJETIVOS PROFISSIONAIS:");
        Objetivos: Console.ReadLine();
            Console.WriteLine("DIGITE SUAS FORMAÇÕES:");
        Formações: Console.ReadLine();
            Console.WriteLine("DIGITE SUA EXPERIÊNCIAS PROFISSIONAIS:");
        Experiencias: Console.ReadLine();
            Console.WriteLine("SEU CURRÍCULO FOI CADASTRADO COM SUCESSO");
            Console.ReadKey();
        }
    }
}
